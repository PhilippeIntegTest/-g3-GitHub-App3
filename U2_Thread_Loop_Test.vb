Option Strict On
Public Class U2_Thread_Loop_Test
    Public Counter_Number_Of_Click As Integer = 0

    Private Sub Button_Thread_Click(sender As Object, e As EventArgs) Handles Button_Thread.Click
        '------------------------------------------------------------------------------
        '---  Show Info on this task    -----------------------------------------------
        '------------------------------------------------------------------------------
        Counter_Number_Of_Click = Counter_Number_Of_Click + 1

        '******************************************************************************
        '****  Part_1: Show some info about the process                           *****
        '******************************************************************************
        TextBox1.Text = "Show Counter Click value Counter= " & Counter_Number_Of_Click.ToString
        TextBox1.BackColor = Color.Azure

        '******************************************************************************
        '****  Part_2: Show some info about the process    [Branch1]              *****
        '******************************************************************************

        
        '******************************************************************************
        '****  Part_3: Show some info about the process    [Branch1]              *****
        '******************************************************************************

        
        '******************************************************************************
        '****  Part_3: Show some info about the process    [Branch2]              *****
        '******************************************************************************


    End Sub
End Class
