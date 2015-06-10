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

    Public Class frmquestionnaires

        Private ad As MySqlDataAdapter

        Private Sub frmquestionnaires_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=us-cdbr-iron-east-01.cleardb.net;user id=bf1c9d658ff1ed;password=3175e2fb;database=ad_5b8045e5aae6ad9;"
            ad = New MySqlDataAdapter("select * from `questionnaires`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.questionnaires)
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
            Dim colname As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colname.DataPropertyName = "name"
            colname.HeaderText = "name"
            colname.Name = "colname"
            dataGridView1.Columns.Add(colname)
            Me.dataGridView1.DataSource = Me.questionnairesBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            questionnairesBindingSource.EndEdit()
            ad.Update(Me.newDataSet.questionnaires)
        End Sub

        Private Sub frmquestionnaires_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
                    row.ErrorText = "The field name is required"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs)
            questionnairesBindingSource.AddNew()
        End Sub

    End Class

End Namespace
