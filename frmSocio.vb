Imports System.Data.SqlClient
Public Class frmSocio

    Public Sub limpiar()
        txtId.Text = ""
        txtTitulo.Text = ""
        txtDirector.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtId.Focus()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpNuevo.Click
        limpiar()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpConsultar.Click
        Dim Consultar As New ClassLibrarySocio.Socio
        With Consultar
            .Id = txtId.Text
            If Consultar.SocioConsulta Then
                txtTitulo.Text = .Nombre
                txtDirector.Text = .Apellido
                txtDireccion.Text = .Direccion
                txtTelefono.Text = .Telefono
            End If
        End With
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpAgregar.Click
        Dim Agregar As New ClassLibrarySocio.Socio
        With Agregar
            .Id = txtId.Text
            .Nombre = txtTitulo.Text
            .Apellido = txtDirector.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
        End With
        If Agregar.SocioAlta Then
        End If
        limpiar()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpModificar.Click
        Dim Modificar As New ClassLibrarySocio.Socio
        With Modificar
            .Nombre = txtTitulo.Text
            .Apellido = txtDirector.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
            .Id = txtId.Text
        End With

        If Modificar.SocioActualiza Then

        End If
        limpiar()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpEliminar.Click
        Dim Eliminar As New ClassLibrarySocio.Socio
        With Eliminar
            .Id = txtId.Text
        End With
        If Eliminar.SocioBaja Then

        End If
        limpiar()
    End Sub

    Private Sub txtId_Leave(sender As Object, e As EventArgs) Handles txtId.Leave
        Dim cnx As New SqlConnection("Server=DESKTOP-QMGI3IR; database=Socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombre1, Apellido1, Direccion1, Telefono1 As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Nombre1 = leer(1).ToString
            Apellido1 = leer(2).ToString
            Direccion1 = leer(3).ToString
            Telefono1 = leer(4).ToString()
            txtTitulo.Text = Nombre1
            txtDirector.Text = Apellido1
            txtDireccion.Text = Direccion1
            txtTelefono.Text = Telefono1
            cnx.Close()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ttpSalir.Click
        End
    End Sub
End Class
