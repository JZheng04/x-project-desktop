﻿Imports MySql.Data.MySqlClient
Public Class frmDetalleTicket
    Private _idTicket As Integer
    Private ticketsDAO As ticketsInterfaces

    Public Sub New(ticketsDAO As ticketsInterfaces, idTicket As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ticketsDAO = ticketsDAO
        _idTicket = idTicket
    End Sub

    Private Sub CargarDetalleTicket()
        Try
            ' Llamar al método en ticketsDAO para obtener el detalle del ticket
            Dim detalle As String = ticketsDAO.ObtenerDetalleTicket(_idTicket)

            ' Asignar el detalle al Label
            lblDetalle.Text = detalle.ToString
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir
            MessageBox.Show("Error al cargar el detalle del ticket: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmDetalleTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDetalleTicket()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        SetPanel(New frmHomeTicket, frmMenu.PanelContent)
    End Sub
End Class