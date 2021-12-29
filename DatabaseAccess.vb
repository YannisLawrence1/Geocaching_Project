Module DatabaseAccess
    Public inc As Integer
    Public ValStore As Integer
    Public con As New OleDb.OleDbConnection

    Public dbProvider As String
    Public dbSource As String
    Public MyDocumentsFolder As String
    Public TheDatabase As String
    Public FullDatabasePath As String
    Public ds As New DataSet


    Public da As OleDb.OleDbDataAdapter
    Public sql As String
    Public MaxRows As Integer

    Public ds2 As New DataSet
    Public da2 As OleDb.OleDbDataAdapter
    Public sql2 As String
    Public MaxRows2 As Integer

    Public ds3 As New DataSet
    Public da3 As OleDb.OleDbDataAdapter
    Public sql3 As String
    Public MaxRows3 As Integer

    Public ds4 As New DataSet
    Public da4 As OleDb.OleDbDataAdapter
    Public sql4 As String
    Public MaxRows4 As Integer

    Public ds5 As New DataSet
    Public da5 As OleDb.OleDbDataAdapter
    Public sql5 As String
    Public MaxRows5 As Integer

    Public ds6 As New DataSet
    Public da6 As OleDb.OleDbDataAdapter
    Public sql6 As String
    Public MaxRows6 As Integer

    Public ds7 As New DataSet
    Public da7 As OleDb.OleDbDataAdapter
    Public sql7 As String
    Public MaxRows7 As Integer

    Public ds8 As New DataSet
    Public da8 As OleDb.OleDbDataAdapter
    Public sql8 As String
    Public MaxRows8 As Integer

    Public userStore As String
    Public access As String
    Public userLocation As Integer

    Public userIdStore As String
    Public code As String
    Public ListName As String
    Public CacheIDStore As String
    Public CacheNameStore As String

    Public adminChanged As String

    Public ds9 As New DataSet
    Public da9 As OleDb.OleDbDataAdapter
    Public sql9 As String
    Public MaxRows9 As Integer
    Public userNameStore

End Module
