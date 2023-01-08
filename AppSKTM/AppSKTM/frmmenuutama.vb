Public Class frmmenuutama

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub


    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        CariDataToolStripMenuItem.Enabled = False
    End Sub

    Private Sub frmmenuutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        frmlogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()

    End Sub

    Private Sub RegisterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterUserToolStripMenuItem.Click
        frmregistrasiuser.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        End
    End Sub

    Private Sub SKTMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SKTMToolStripMenuItem.Click
        frmsktm.ShowDialog()
    End Sub

    Private Sub SKCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SKCKToolStripMenuItem.Click
        frmskck.ShowDialog()
    End Sub

    Private Sub KTPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KTPToolStripMenuItem.Click
        frmktp.ShowDialog()
    End Sub

    Private Sub SKTMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SKTMToolStripMenuItem1.Click
        frmcaridatasktm.ShowDialog()
    End Sub

    Private Sub SKCKToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SKCKToolStripMenuItem1.Click
        frmcaridataskck.ShowDialog()
    End Sub

    Private Sub KTPToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KTPToolStripMenuItem1.Click
        frmcaridataktp.ShowDialog()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegawaiToolStripMenuItem.Click
        frmcaridatapegawai.ShowDialog()
    End Sub
End Class
