Public Class splash

    Private Sub exerciseTwo_Click(sender As Object, e As EventArgs) Handles exerciseTwo.Click
        Me.Hide()
        exercise2.Show()
    End Sub

    Private Sub esleiterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles esleiterLink.LinkClicked
        Process.Start("https://esleiter.com/")
    End Sub
End Class
