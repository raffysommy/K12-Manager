Imports System.Windows.Forms
Imports K12_Manager.K12_Manager

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Crea una nuova istanza del form figlio.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Imposta il form come figlio di questo form MDI prima di visualizzarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Finestra " & m_ChildFormNumber

        ChildForm.Show()
    End Sub




    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Chiude tutti i form figlio del form padre.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer



    Private Sub TokenDiAccessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokenDiAccessoToolStripMenuItem.Click
        Dim f As frmoauth_access_tokens = New frmoauth_access_tokens()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub CodiciDiAutorizzazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodiciDiAutorizzazioneToolStripMenuItem.Click
        Dim f As frmoauth_authorization_codes = New frmoauth_authorization_codes()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub UtentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtentiToolStripMenuItem.Click
        Dim f As frmoauth_users = New frmoauth_users()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientToolStripMenuItem.Click
        Dim f As frmoauth_clients = New frmoauth_clients()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub TokenRigenerazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokenRigenerazioneToolStripMenuItem.Click
        Dim f As frmoauth_refresh_tokens = New frmoauth_refresh_tokens()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub QuestionariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestionariToolStripMenuItem.Click
        Dim f As frmquestionnaires = New frmquestionnaires()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub DomandeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomandeToolStripMenuItem.Click
        Dim f As frmquestions = New frmquestions()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub ArgomentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArgomentiToolStripMenuItem.Click
        Dim f As frmtopics = New frmtopics()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub DomandeDeiQuestionariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DomandeDeiQuestionariToolStripMenuItem.Click
        Dim f As frmquestions_questionnaires = New frmquestions_questionnaires()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub MessaggiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessaggiToolStripMenuItem.Click
        Dim f As frmmessages = New frmmessages()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub
End Class
