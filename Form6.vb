﻿Imports System.IO

Public Class Form6
    Dim path_sc As String
    Dim path_cm As String
    Dim dataType As String
    Dim ch_cl As String = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If My.Settings.check_newScCm = 1 Then

        If TextBox1.Text <> vbNullString Then
            If My.Settings.Chcom_CmSc = 1 Then
                File.WriteAllText(path_sc + TextBox1.Text + dataType, "")
            End If
            If My.Settings.Chcom_CmSc = 2 Then
                File.WriteAllText(path_cm + TextBox1.Text + dataType, "")
            End If

            My.Settings.ComboAvs = TextBox1.Text
                Me.Close()

            End If
            If TextBox1.Text = vbNullString Then
            Label2.Text = "Input your script name ..."
        End If


        ' End If

    End Sub
    Private Sub Check_cmdOrsc()
        If ComboBox2.SelectedItem = "script" Then
            My.Settings.Chcom_CmSc = 1
        End If
        If ComboBox2.SelectedItem = "cmdline" Then
            My.Settings.Chcom_CmSc = 2
        End If
    End Sub
    Private Sub Check_cmdOrsc_linked()
        If My.Settings.Chcom_CmSc = 1 Then
            ComboBox2.SelectedItem = "script"
        End If
        If My.Settings.Chcom_CmSc = 2 Then
            ComboBox2.SelectedItem = "cmdline"
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check_cmdOrsc_linked()
        Label2.Text = " "
        If My.Settings.check_newScCm = "1" Then
            ComboBox1.SelectedItem = "AviSynth script"
            path_sc = ".\avss\"
            path_cm = ".\avss\"
            dataType = ".avs"
            ch_cl = "1"
        End If
        If My.Settings.check_newScCm = "2" Then
            ComboBox1.SelectedItem = "Other Type"
            path_sc = ".\scripts_etc\"
            path_cm = ".\cmdline_etc\"
            dataType = ".txt"
            ch_cl = "2"
        End If
        If My.Settings.check_newScCm = "3" Then
            ComboBox1.SelectedItem = "Video Type"
            path_sc = ".\scripts_vdo\"
            path_cm = ".\cmdline_vdo\"
            dataType = ".txt"
            ch_cl = "2"
        End If
        If My.Settings.check_newScCm = "4" Then
            ComboBox1.SelectedItem = "Audio Type"
            path_sc = ".\scripts_aud\"
            path_cm = ".\cmdline_aud\"
            dataType = ".txt"
            ch_cl = "2"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
    Private Sub Form6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If ch_cl = 1 Then
            Form5.Show()
        End If
        If ch_cl = 2 Then
            Form2.Show()
        End If


        ' Form5.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "AviSynth script" Then
            path_sc = ".\avss\"
            path_cm = ".\avss\"
            dataType = ".avs"
            ch_cl = "1"
        End If
        If ComboBox1.SelectedItem = "Queue script" Then
            path_sc = ".\scripts_etc\"
            path_cm = ".\cmdline_etc\"
            dataType = ".txt"
            ch_cl = "2"
        End If
        If ComboBox1.SelectedItem = "Video cmdline" Then
            path_sc = ".\scripts_vdo\"
            path_cm = ".\cmdline_vdo\"
            dataType = ".txt"
            ch_cl = "2"
        End If
        If ComboBox1.SelectedItem = "Audio cmdline" Then
            path_sc = ".\scripts_aud\"
            path_cm = ".\cmdline_vdo\"
            dataType = ".txt"
            ch_cl = "2"
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Check_cmdOrsc()
    End Sub
End Class