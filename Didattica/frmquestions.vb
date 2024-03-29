' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Namespace K12_Manager

    Public Class frmquestions

        Private ad As MySqlDataAdapter

        Private Sub frmquestions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=us-cdbr-iron-east-01.cleardb.net;user id=bf1c9d658ff1ed;password=3175e2fb;database=ad_5b8045e5aae6ad9;"
            ad = New MySqlDataAdapter("select * from `questions`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.questions)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorCountItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True
            ToolStripButton1.Enabled = True
            dataGridView1.AutoGenerateColumns = False
            Dim strConn2 As String = "port=3306;server=us-cdbr-iron-east-01.cleardb.net;user id=bf1c9d658ff1ed;password=3175e2fb;database=ad_5b8045e5aae6ad9;"
            Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing
            Dim colid As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colid.DataPropertyName = "id"
            colid.HeaderText = "id"
            colid.Name = "colid"
            dataGridView1.Columns.Add(colid)
            Dim colbody As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colbody.DataPropertyName = "body"
            colbody.HeaderText = "body"
            colbody.Name = "colbody"
            dataGridView1.Columns.Add(colbody)
            Dim colanswer As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colanswer.DataPropertyName = "answer"
            colanswer.HeaderText = "answer"
            colanswer.Name = "colanswer"
            dataGridView1.Columns.Add(colanswer)
            Dim colfakeAnswer1 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colfakeAnswer1.DataPropertyName = "fakeAnswer1"
            colfakeAnswer1.HeaderText = "fakeAnswer1"
            colfakeAnswer1.Name = "colfakeAnswer1"
            dataGridView1.Columns.Add(colfakeAnswer1)
            Dim colfakeAnswer2 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colfakeAnswer2.DataPropertyName = "fakeAnswer2"
            colfakeAnswer2.HeaderText = "fakeAnswer2"
            colfakeAnswer2.Name = "colfakeAnswer2"
            dataGridView1.Columns.Add(colfakeAnswer2)
            Dim colfakeAnswer3 As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colfakeAnswer3.DataPropertyName = "fakeAnswer3"
            colfakeAnswer3.HeaderText = "fakeAnswer3"
            colfakeAnswer3.Name = "colfakeAnswer3"
            dataGridView1.Columns.Add(colfakeAnswer3)
            Dim coltopic As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `topics`", strConn2)
            ad2.Fill(Me.newDataSet.topics)
            coltopic.DataSource = Me.newDataSet.topics
            coltopic.DataPropertyName = "topic"
            coltopic.DisplayMember = "name"
            coltopic.ValueMember = "name"
            coltopic.HeaderText = "topic"
            coltopic.Name = "coltopic"
            coltopic.ToolTipText = "Pick the column from the foreign table to use as friendly value for this lookup."
            dataGridView1.Columns.Add(coltopic)
            Me.dataGridView1.DataSource = Me.questionsBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            questionsBindingSource.EndEdit()
            ad.Update(Me.newDataSet.questions)
        End Sub

        Private Sub frmquestions_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)

            Dim s As String
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            Dim value As Object = e.FormattedValue
            e.Cancel = False
            row.ErrorText = ""
            If row.IsNewRow Then
                Return
            End If
            If e.ColumnIndex = 0 Then

                Dim v As Integer
                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field id is required"
                    Return
                End If
                s = value.ToString()
                If Not Integer.TryParse(s, v) Then
                    e.Cancel = True
                    row.ErrorText = "The field id must be Integer."
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field body is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field answer is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 3 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field fakeAnswer1 is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 4 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field fakeAnswer2 is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 5 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field fakeAnswer3 is required"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs)
            questionsBindingSource.AddNew()
        End Sub

    End Class

End Namespace
