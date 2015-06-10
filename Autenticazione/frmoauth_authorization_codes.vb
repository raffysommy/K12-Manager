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
Imports System.Drawing

Namespace K12_Manager

    Public Class frmoauth_authorization_codes

        Private ad As MySqlDataAdapter

        Private Sub frmoauth_authorization_codes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=us-cdbr-iron-east-01.cleardb.net;user id=bf1c9d658ff1ed;password=3175e2fb;database=ad_5b8045e5aae6ad9;"
            ad = New MySqlDataAdapter("select * from `oauth_authorization_codes`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.oauth_authorization_codes)
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
            Dim colauthorization_code As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colauthorization_code.DataPropertyName = "authorization_code"
            colauthorization_code.HeaderText = "authorization_code"
            colauthorization_code.Name = "colauthorization_code"
            dataGridView1.Columns.Add(colauthorization_code)
            Dim colclient_id As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colclient_id.DataPropertyName = "client_id"
            colclient_id.HeaderText = "client_id"
            colclient_id.Name = "colclient_id"
            dataGridView1.Columns.Add(colclient_id)
            Dim coluser_id As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            coluser_id.DataPropertyName = "user_id"
            coluser_id.HeaderText = "user_id"
            coluser_id.Name = "coluser_id"
            dataGridView1.Columns.Add(coluser_id)
            Dim colredirect_uri As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colredirect_uri.DataPropertyName = "redirect_uri"
            colredirect_uri.HeaderText = "redirect_uri"
            colredirect_uri.Name = "colredirect_uri"
            dataGridView1.Columns.Add(colredirect_uri)
            Dim colexpires As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colexpires.DataPropertyName = "expires"
            colexpires.HeaderText = "expires"
            colexpires.Name = "colexpires"
            colexpires.ReadOnly = True
            colexpires.DefaultCellStyle.BackColor = Color.LightGray
            dataGridView1.Columns.Add(colexpires)
            Dim colscope As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colscope.DataPropertyName = "scope"
            colscope.HeaderText = "scope"
            colscope.Name = "colscope"
            dataGridView1.Columns.Add(colscope)
            Dim colid_token As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colid_token.DataPropertyName = "id_token"
            colid_token.HeaderText = "id_token"
            colid_token.Name = "colid_token"
            dataGridView1.Columns.Add(colid_token)
            Me.dataGridView1.DataSource = Me.oauth_authorization_codesBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            If TypeOf (CType(oauth_authorization_codesBindingSource.Current, DataRowView)("expires")) Is DBNull Then
                CType(oauth_authorization_codesBindingSource.Current, DataRowView)("expires") = DateTime.Now
            End If
            oauth_authorization_codesBindingSource.EndEdit()
            ad.Update(Me.newDataSet.oauth_authorization_codes)
        End Sub

        Private Sub frmoauth_authorization_codes_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)


            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            Dim value As Object = e.FormattedValue
            e.Cancel = False
            row.ErrorText = ""
            If row.IsNewRow Then
                Return
            End If
            If e.ColumnIndex = 0 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field authorization_code is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field client_id is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field user_id is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 3 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field redirect_uri is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 4 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field expires is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 5 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field scope is required"
                    Return
                End If
            End If
            If e.ColumnIndex = 6 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "The field id_token is required"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs)
            oauth_authorization_codesBindingSource.AddNew()
        End Sub

    End Class

End Namespace