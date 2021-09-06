Imports System
Imports System.Text
Imports System.Drawing
Imports System.IO.Ports
Imports System.Windows.Forms
'*****************************************************************************************
'                           LICENSE INFORMATION
'*****************************************************************************************
'   PCCom.SerialCommunication Version 1.0.0.0
'   Class file for managing serial port communication
'
'   Copyright (C) 2007  
'   Hakan KOCATEPE
'   Email: hakan@kocatepe
'   Created: 02FEB17
'
'   This program is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.
'
'   This program is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.
'
'   You should have received a copy of the GNU General Public License
'   along with this program.  If not, see <http://www.gnu.org/licenses/>.
'*****************************************************************************************


Public Class CommManager
#Region "Manager Enums"
    ''' <summary>
    ''' enumeration to hold our transmission types
    ''' </summary>
    Public Enum TransmissionType
        Text
        Hex
    End Enum

    ''' <summary>
    ''' enumeration to hold our message types
    ''' </summary>
    Public Enum MessageType
        Incoming
        Outgoing
        Normal
        Warning
        [Error]
    End Enum
#End Region

#Region "Manager Variables"
    'property variables
    Private _baudRate As String = String.Empty
    Private _parity As String = String.Empty
    Private _stopBits As String = String.Empty
    Private _dataBits As String = String.Empty
    Private _portName As String = String.Empty
    Private _transType As TransmissionType
    Private _displayWindow As TextBox
    Private _Mask As Boolean = False
    Private _msg As String
    Private _len As UInt16
    Private _STX As Char = Nothing
    Private _ETX As Char
    Private _type As MessageType
    'global manager variables
    'Private MessageColor As Color() = {Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red}
    Public comPort As New SerialPort()
    Private write As Boolean = True
#End Region

#Region "Manager Properties"



    ''' <summary>
    ''' Property to hold the BaudRate
    ''' of our manager class
    ''' </summary>
    Public Property BaudRate() As String
        Get
            Return _baudRate
        End Get
        Set(ByVal value As String)
            _baudRate = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the Parity
    ''' of our manager class
    ''' </summary>
    Public Property Parity() As String
        Get
            Return _parity
        End Get
        Set(ByVal value As String)
            _parity = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the StopBits
    ''' of our manager class
    ''' </summary>
    Public Property StopBits() As String
        Get
            Return _stopBits
        End Get
        Set(ByVal value As String)
            _stopBits = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the DataBits
    ''' of our manager class
    ''' </summary>
    Public Property DataBits() As String
        Get
            Return _dataBits
        End Get
        Set(ByVal value As String)
            _dataBits = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the PortName
    ''' of our manager class
    ''' </summary>
    Public Property PortName() As String
        Get
            Return _portName
        End Get
        Set(ByVal value As String)
            _portName = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold our TransmissionType
    ''' of our manager class
    ''' </summary>
    Public Property CurrentTransmissionType() As TransmissionType
        Get
            Return _transType
        End Get
        Set(ByVal value As TransmissionType)
            _transType = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the Mask
    ''' of our manager class
    ''' </summary>
    Public Property Mask() As Boolean
        Get
            Return _Mask
        End Get
        Set(ByVal value As Boolean)
            _Mask = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold the Mask
    ''' of our manager class
    ''' </summary>
    Public Property len() As UInt16
        Get
            Return _len
        End Get
        Set(ByVal value As UInt16)
            _len = value
        End Set
    End Property
    ''' <summary>
    ''' property to hold the Mask
    ''' of our manager class
    ''' </summary>
    Public Property STX() As Char
        Get
            Return _STX
        End Get
        Set(ByVal value As Char)
            _STX = value
        End Set
    End Property
    ''' <summary>
    ''' property to hold the Mask
    ''' of our manager class
    ''' </summary>
    Public Property ETX() As Char
        Get
            Return _ETX
        End Get
        Set(ByVal value As Char)
            _ETX = value
        End Set
    End Property

    ''' <summary>
    ''' property to hold our display window
    ''' value
    ''' </summary>
    Public Property DisplayWindow() As TextBox
        Get
            Return _displayWindow
        End Get
        Set(ByVal value As TextBox)
            _displayWindow = value
        End Set
    End Property

    ''' <summary>
    ''' Property to hold the message being sent
    ''' through the serial port
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Message() As String
        Get
            Return _msg
        End Get
        Set(ByVal value As String)
            _msg = value
        End Set
    End Property

    ''' <summary>
    ''' Message to hold the transmission type
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Type() As MessageType
        Get
            Return _type
        End Get
        Set(ByVal value As MessageType)
            _type = value
        End Set
    End Property
#End Region

#Region "Manager Constructors"
    ''' <summary>
    ''' Constructor to set the properties of our Manager Class
    ''' </summary>
    ''' <param name="baud">Desired BaudRate</param>
    ''' <param name="par">Desired Parity</param>
    ''' <param name="sBits">Desired StopBits</param>
    ''' <param name="dBits">Desired DataBits</param>
    ''' <param name="name">Desired PortName</param>
    Public Sub New(ByVal baud As String, ByVal par As String, ByVal sBits As String, ByVal dBits As String, ByVal name As String, ByVal rtb As TextBox)
        _baudRate = baud
        _parity = par
        _stopBits = sBits
        _dataBits = dBits
        _portName = name
        _displayWindow = rtb
        'now add an event handler
        AddHandler comPort.DataReceived, AddressOf comPort_DataReceived
    End Sub

    ''' <summary>
    ''' Comstructor to set the properties of our
    ''' serial port communicator to nothing
    ''' </summary>
    Public Sub New()
        _baudRate = String.Empty
        _parity = String.Empty
        _stopBits = String.Empty
        _dataBits = String.Empty
        _portName = "COM4"
        _displayWindow = Nothing
        'add event handler
        AddHandler comPort.DataReceived, AddressOf comPort_DataReceived
    End Sub
#End Region

#Region "WriteData"
    Public Sub WriteData(ByVal msg As String)
        Select Case CurrentTransmissionType
            Case TransmissionType.Text
                'first make sure the port is open
                'if its not open then open it
                If Not (comPort.IsOpen = True) Then
                    comPort.Open()
                End If
                'send the message to the port
                comPort.Write(msg)
                'display the message
                _type = MessageType.Outgoing
                _msg = msg + "" + Environment.NewLine + ""
                'DisplayData(_type, _msg)
                Exit Select
            Case TransmissionType.Hex
                Try
                    'convert the message to byte array
                    Dim newMsg As Byte() = HexToByte(msg)
                    If Not write Then
                        'DisplayData(_type, _msg)
                        Exit Sub
                    End If
                    'send the message to the port
                    comPort.Write(newMsg, 0, newMsg.Length)
                    'convert back to hex and display
                    _type = MessageType.Outgoing
                    _msg = ByteToHex(newMsg) + "" + Environment.NewLine + ""
                    'DisplayData(_type, _msg)
                Catch ex As FormatException
                    'display error message
                    _type = MessageType.Error
                    _msg = ex.Message + "" + Environment.NewLine + ""
                    'DisplayData(_type, _msg)
                Finally
                    _displayWindow.SelectAll()
                End Try
                Exit Select
            Case Else
                'first make sure the port is open
                'if its not open then open it
                If Not (comPort.IsOpen = True) Then
                    comPort.Open()
                End If
                'send the message to the port
                comPort.Write(msg)
                'display the message
                _type = MessageType.Outgoing
                _msg = msg + "" + Environment.NewLine + ""
                'DisplayData(MessageType.Outgoing, msg + "" + Environment.NewLine + "")
                Exit Select
        End Select
    End Sub
#End Region

#Region "HexToByte"
    ''' <summary>
    ''' method to convert hex string into a byte array
    ''' </summary>
    ''' <param name="msg">string to convert</param>
    ''' <returns>a byte array</returns>
    Private Function HexToByte(ByVal msg As String) As Byte()
        If msg.Length Mod 2 = 0 Then
            'remove any spaces from the string
            _msg = msg
            _msg = msg.Replace(" ", "")
            'create a byte array the length of the
            'divided by 2 (Hex is 2 characters in length)
            Dim comBuffer As Byte() = New Byte(_msg.Length / 2 - 1) {}
            For i As Integer = 0 To _msg.Length - 1 Step 2
                comBuffer(i / 2) = CByte(Convert.ToByte(_msg.Substring(i, 2), 16))
            Next
            write = True
            'loop through the length of the provided string
            'convert each set of 2 characters to a byte
            'and add to the array
            'return the array
            Return comBuffer
        Else
            _msg = "Invalid format"
            _type = MessageType.Error
            ' DisplayData(_Type, _msg)
            write = False
            Return Nothing
        End If
    End Function
#End Region

#Region "ByteToHex"
    ''' <summary>
    ''' method to convert a byte array into a hex string
    ''' </summary>
    ''' <param name="comByte">byte array to convert</param>
    ''' <returns>a hex string</returns>
    Private Function ByteToHex(ByVal comByte As Byte()) As String
        'create a new StringBuilder object
        Dim builder As New StringBuilder(comByte.Length * 2)
        'loop through each byte in the array
        For Each data As Byte In comByte
            builder.Append(Convert.ToString(data, 16).PadLeft(2, "0"c))
            'convert the byte to a string and add to the stringbuilder
        Next
        ' dirty trick begin
        If Not _Mask Then
            builder.Remove(0, 4)
        Else
            builder.Remove(0, 2)
        End If
        builder.Remove(builder.Length - 2, 2)
        ' dirty trick end
        'return the converted value
        Return builder.ToString().ToUpper()
    End Function
#End Region

#Region "DisplayData"
    ''' <summary>
    ''' Method to display the data to and
    ''' from the port on the screen
    ''' </summary>
    ''' <remarks></remarks>
    <STAThread()>
    Private Sub DisplayData(ByVal type As MessageType, ByVal msg As String)
        _displayWindow.Invoke(New EventHandler(AddressOf DoDisplay))
    End Sub
#End Region

#Region "OpenPort"
    Public Function OpenPort() As Boolean
        Try
            'first check if the port is already open
            'if its open then close it
            If comPort.IsOpen = True Then
                comPort.Close()
            End If

            'set the properties of our SerialPort Object
            comPort.BaudRate = Integer.Parse(_baudRate)
            'BaudRate
            comPort.DataBits = Integer.Parse(_dataBits)
            'DataBits
            comPort.StopBits = DirectCast([Enum].Parse(GetType(StopBits), _stopBits), StopBits)
            'StopBits
            comPort.Parity = DirectCast([Enum].Parse(GetType(Parity), _parity), Parity)
            'Parity
            comPort.PortName = _portName
            'PortName
            'now open the port
            comPort.Open()
            'return true
            Return True
        Catch ex As Exception
            'DisplayData(MessageType.[Error], ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region " ClosePort "
    Public Sub ClosePort()
        If comPort.IsOpen Then
            comPort.DiscardInBuffer()
            comPort.Close()
            'comPort.Dispose()
        End If
    End Sub
#End Region

#Region "SetParityValues"
    Public Sub SetParityValues(ByVal obj As Object)
        For Each str As String In [Enum].GetNames(GetType(Parity))
            DirectCast(obj, ComboBox).Items.Add(str)
        Next
    End Sub
#End Region

#Region "SetStopBitValues"
    Public Sub SetStopBitValues(ByVal obj As Object)
        For Each str As String In [Enum].GetNames(GetType(StopBits))
            DirectCast(obj, ComboBox).Items.Add(str)
        Next
    End Sub
#End Region

#Region "SetPortNameValues"
    Public Sub SetPortNameValues(ByVal obj As Object)

        For Each str As String In SerialPort.GetPortNames()
            DirectCast(obj, ComboBox).Items.Add(str)
        Next
    End Sub
#End Region

#Region "comPort_DataReceived"
    ''' <summary>
    ''' method that will be called when theres data waiting in the buffer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub comPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        'determine the mode the user selected (binary/string)



        Select Case CurrentTransmissionType
            Case TransmissionType.Text
                'user chose string
                'read data waiting in the buffer
                Dim msg As String = comPort.ReadExisting()
                'msg.Replace(vbNullChar, "")
                'display the data to the user
                _type = MessageType.Incoming
                _msg += msg
                If _msg.Length >= 3 Then
                    If _STX <> Nothing Then
                        If (_msg.LastIndexOf(_STX) <> -1) And (_msg.LastIndexOf(_ETX) <> -1) And (_msg.LastIndexOf(_ETX) > _msg.LastIndexOf(_STX)) Then
                            _msg = _msg.Substring(_msg.LastIndexOf(_STX))
                            _msg = _msg.Substring(0, _msg.LastIndexOf(_ETX) + 1)
                            '_msg.Replace(vbNullChar, "")
                            DisplayData(MessageType.Incoming, _msg)
                            _msg = String.Empty
                        End If
                    Else
                        If _msg.Last = _ETX Then
                            '_msg = _msg.Substring(_msg.LastIndexOf(_ETX) + 1)
                            DisplayData(MessageType.Incoming, _msg)
                            _msg = String.Empty
                        End If
                    End If
                End If
                Exit Select
            Case TransmissionType.Hex
                If comPort.BytesToRead >= _len Then
                    'user chose binary
                    'retrieve number of bytes in the buffer
                    'Dim bytes As Integer = comPort.BytesToRead
                    'create a byte array to hold the awaiting data
                    Dim comBuffer As Byte() = New Byte(_len - 1) {}
                    'read the data and store it
                    comPort.Read(comBuffer, 0, _len)
                    'display the data to the user
                    _type = MessageType.Incoming
                    _msg = ByteToHex(comBuffer) + "" + Environment.NewLine + ""
                    DisplayData(MessageType.Incoming, _msg + "" + Environment.NewLine + "")
                    If comPort.BytesToRead > 0 Then
                        comPort_DataReceived(sender, e)
                    End If
                End If
                Exit Select
            Case Else
                'read data waiting in the buffer
                Dim str As String = comPort.ReadExisting()
                'display the data to the user
                _type = MessageType.Incoming
                _msg = str + "" + Environment.NewLine + ""
                DisplayData(MessageType.Incoming, str + "" + Environment.NewLine + "")
                Exit Select
        End Select

    End Sub
#End Region

#Region "DoDisplay"
    Private Sub DoDisplay(ByVal sender As Object, ByVal e As EventArgs)

        While Not _displayWindow.Text = String.Empty
            Threading.Thread.Sleep(1)
        End While
        _displayWindow.SelectedText = String.Empty
        _displayWindow.Text = _msg
        _displayWindow.ScrollToCaret()

    End Sub
#End Region
End Class

