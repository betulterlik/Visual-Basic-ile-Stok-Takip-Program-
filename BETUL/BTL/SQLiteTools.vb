Imports System.Data.SQLite
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class SQLiteTools

    Public Property DB As String
    Public Sub New(ByVal DBString As String, Optional ByVal path As Boolean = False)

        _DB = DBString
        If path Then
            cons.ConnectionString = "Data Source =" & _DB
        Else
            'cons.ConnectionString = "Data Source =" + Application.StartupPath + "\" & _DB & ".s3db"
               cons.ConnectionString = "Data Source =" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ELOPAR\" & Application.ProductName + "\" & _DB & ".s3db"
        End If
    End Sub

    Public cons As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public sql As String
    Public strSQL As String
    Public ds As New DataSet
    Public da As New SQLiteDataAdapter

    Public Sub ExecuteNonQuery(ByRef s As String)

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        cmd.ExecuteNonQuery()
        cons.Close()

    End Sub

    Function GetSingleValue(ByRef s As String, ByRef val As String) As String

        Dim SQLreader As SQLiteDataReader
        Dim dummy As String = String.Empty

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader

        While SQLreader.Read
            dummy = SQLreader(val)
        End While

        cmd.Dispose()
        SQLreader.Close()
        cons.Close()

        Return dummy

    End Function

    Function PopulateGrid(ByRef s As String) As DataTable

        Dim SQLreader As SQLiteDataReader

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader


        Dim dt = New DataTable()
        dt.Load(SQLreader)

        SQLreader.Close()
        cons.Close()

        Return dt

    End Function

    Function columnCount(ByRef tablename As String) As Integer

        Dim SQLreader As SQLiteDataReader

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = "pragma table_info(" & tablename & ") "
        SQLreader = cmd.ExecuteReader

        Dim dt = New DataTable()
        dt.Load(SQLreader)

        SQLreader.Close()
        cons.Close()

        Return dt.Rows.Count

    End Function

    Function GetImageS(ByRef s As String) As ImageList

        Dim SQLreader As SQLiteDataReader
        Dim i As New ImageList()

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader
        While SQLreader.Read
            i.Images.Add(BlobToImage(SQLreader("LngPic")))
        End While
        cmd.Dispose()
        SQLreader.Close()
        cons.Close()

        Return i

    End Function

    Function GetImage(ByRef s As String, ByRef parameter As String) As Image

        Dim SQLreader As SQLiteDataReader
        Dim i As Image

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader
        SQLreader.Read()
        i = BlobToImage(SQLreader(parameter))
        cmd.Dispose()
        SQLreader.Close()
        cons.Close()

        Return i

    End Function

    Public Sub SetImage(ByRef s As String, ByRef parameter As String, ByRef i As Image)

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        cmd.Prepare()
        cmd.Parameters.Add(ImageToBlob(parameter, i))
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cons.Close()

    End Sub

    Function PopulateComboBox(ByVal s As String, ByRef paramater As String, ByRef insertHeader As Boolean) As List(Of String)

        Dim SQLreader As SQLiteDataReader
        Dim DummyComboBox As List(Of String) = Nothing

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader

        DummyComboBox = New List(Of String)()
        If insertHeader Then
            DummyComboBox.Add("Please Select")
        End If
        While SQLreader.Read()
            DummyComboBox.Add(SQLreader(paramater))
        End While
        SQLreader.Close()
        cons.Close()

        Return DummyComboBox

    End Function

    Function BlobToImage(ByVal blob) As Image

        Dim ms As New IO.MemoryStream
        Dim d As Byte() = DirectCast(blob, Byte())
        ms.Write(d, 0, Convert.ToInt32(d.Length))
        Dim b As Bitmap = New Bitmap(ms, False)
        ms.Dispose()

        Return b

    End Function

    Function ImageToBlob(ByVal s As String, ByVal i As Image) As SQLiteParameter

        Dim ms As New MemoryStream()
        i.Save(ms, i.RawFormat)
        Dim d As Byte() = ms.GetBuffer()
        Dim parameter As New SQLiteParameter(s, d)
        parameter.DbType = DbType.Binary
        parameter.Value = d
        ms.Dispose()

        Return parameter

    End Function


    Function isThere(ByRef s As String) As Boolean

        Dim dummy As Boolean = False
        Dim SQLreader As SQLiteDataReader
        Dim DummyComboBox As List(Of String) = Nothing

        cons.OpenAsync()
        cmd = cons.CreateCommand
        cmd.CommandText = s
        SQLreader = cmd.ExecuteReader

        SQLreader.Read()

        If SQLreader.HasRows Then
            dummy = False
        Else
            dummy = True
        End If

        SQLreader.Close()
        cons.Close()

        Return dummy

    End Function

End Class
