﻿Public Class frmhora
    Private Sub labelhora_Click(sender As Object, e As EventArgs) Handles labelhora.Click

    End Sub

    Private Sub timerhora_Tick(sender As Object, e As EventArgs) Handles timerhora.Tick
        labelhora.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    Private Sub timerfecha_Tick(sender As Object, e As EventArgs) Handles timerfecha.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        labelfecha.Text = fecha
    End Sub

    Private Sub labelfecha_Click(sender As Object, e As EventArgs) Handles labelfecha.Click

    End Sub

    Private Sub frmhora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerfecha.Start()
        DateTimePicker1.Visible = False
    End Sub
End Class