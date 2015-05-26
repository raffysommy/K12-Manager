
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Namespace K12_Manager

Public Class frmMain

    Private Sub frmmessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmmessagesToolStripMenuItem.Click
      Dim f As frmmessages = New frmmessages()
      f.Show()
    End Sub

    Private Sub frmoauth_access_tokensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_access_tokensToolStripMenuItem.Click
      Dim f As frmoauth_access_tokens = New frmoauth_access_tokens()
      f.Show()
    End Sub

    Private Sub frmoauth_authorization_codesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_authorization_codesToolStripMenuItem.Click
      Dim f As frmoauth_authorization_codes = New frmoauth_authorization_codes()
      f.Show()
    End Sub

    Private Sub frmoauth_clientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_clientsToolStripMenuItem.Click
      Dim f As frmoauth_clients = New frmoauth_clients()
      f.Show()
    End Sub

    Private Sub frmoauth_jwtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_jwtToolStripMenuItem.Click
      Dim f As frmoauth_jwt = New frmoauth_jwt()
      f.Show()
    End Sub

    Private Sub frmoauth_refresh_tokensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_refresh_tokensToolStripMenuItem.Click
      Dim f As frmoauth_refresh_tokens = New frmoauth_refresh_tokens()
      f.Show()
    End Sub

    Private Sub frmoauth_usersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmoauth_usersToolStripMenuItem.Click
      Dim f As frmoauth_users = New frmoauth_users()
      f.Show()
    End Sub

    Private Sub frmquestionnairesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmquestionnairesToolStripMenuItem.Click
      Dim f As frmquestionnaires = New frmquestionnaires()
      f.Show()
    End Sub

    Private Sub frmquestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmquestionsToolStripMenuItem.Click
      Dim f As frmquestions = New frmquestions()
      f.Show()
    End Sub

    Private Sub frmquestions_questionnairesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmquestions_questionnairesToolStripMenuItem.Click
      Dim f As frmquestions_questionnaires = New frmquestions_questionnaires()
      f.Show()
    End Sub

    Private Sub frmtopicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmtopicsToolStripMenuItem.Click
      Dim f As frmtopics = New frmtopics()
      f.Show()
    End Sub

    Private Sub frmuserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles frmuserToolStripMenuItem.Click
      Dim f As frmuser = New frmuser()
      f.Show()
    End Sub

        Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub
    End Class

End Namespace