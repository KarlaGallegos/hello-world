Imports System.Data.SqlClient
Public Class Socio
#Region "Definicion de las propiedades"
    Private MstrId As String
    Private MstrNombre As String
    Private MstrApellido As String
    Private MstrDireccion As String
    Private MstrTelefono As String
#End Region

#Region "Hacer publico el acceso a las propiedades"
    Public Property Id() As String
        Get
            Return MstrId
        End Get
        Set(ByVal value As String)
            MstrId = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return MstrNombre
        End Get
        Set(ByVal value As String)
            MstrNombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return MstrApellido
        End Get
        Set(ByVal value As String)
            MstrApellido = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return MstrDireccion
        End Get
        Set(ByVal value As String)
            MstrDireccion = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return MstrTelefono
        End Get
        Set(ByVal value As String)
            MstrTelefono = value
        End Set
    End Property
#End Region

#Region "Definicion de metodos"
    Public Function SocioAlta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-QMGI3IR; database=Socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocAlta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function SocioBaja() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-QMGI3IR; database=Socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function SocioActualiza() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-QMGI3IR; database=Socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function SocioConsulta() As Boolean
        Dim cnx As New SqlConnection("Server=DESKTOP-QMGI3IR; database=Socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim NombreSocio1, ApellidoSocio1, DireccionSocio1, TelefonoSocio1 As String
        Dim pasar As Boolean
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            NombreSocio1 = leer(1).ToString
            ApellidoSocio1 = leer(2).ToString
            DireccionSocio1 = leer(3).ToString
            TelefonoSocio1 = leer(4).ToString
            Nombre = NombreSocio1
            Apellido = ApellidoSocio1
            Direccion = DireccionSocio1
            Telefono = TelefonoSocio1
            cnx.Close()
        End If
        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

End Class
