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

Namespace K12_Manager
	
	Public Class frmoauth_users
		
		Private ad As MySqlDataAdapter
		
		Private Sub frmoauth_users_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=us-cdbr-iron-east-01.cleardb.net;user id=bf1c9d658ff1ed;password=3175e2fb;database=ad_5b8045e5aae6ad9;"
            ad = New MySqlDataAdapter("select * from `oauth_users`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.oauth_users)
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
			Dim coluser_id As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			coluser_id.DataPropertyName = "user_id"
			coluser_id.HeaderText = "user_id"
			coluser_id.Name = "coluser_id"
			dataGridView1.Columns.Add(coluser_id)
			Dim colusername As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colusername.DataPropertyName = "username"
			colusername.HeaderText = "username"
			colusername.Name = "colusername"
			dataGridView1.Columns.Add(colusername)
			Dim colpassword As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colpassword.DataPropertyName = "password"
			colpassword.HeaderText = "password"
			colpassword.Name = "colpassword"
			dataGridView1.Columns.Add(colpassword)
			Dim colfirst_name As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colfirst_name.DataPropertyName = "first_name"
			colfirst_name.HeaderText = "first_name"
			colfirst_name.Name = "colfirst_name"
			dataGridView1.Columns.Add(colfirst_name)
			Dim collast_name As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			collast_name.DataPropertyName = "last_name"
			collast_name.HeaderText = "last_name"
			collast_name.Name = "collast_name"
			dataGridView1.Columns.Add(collast_name)
			Dim colemail As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colemail.DataPropertyName = "email"
			colemail.HeaderText = "email"
			colemail.Name = "colemail"
			dataGridView1.Columns.Add(colemail)
			Dim colrole As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colrole.DataPropertyName = "role"
			colrole.HeaderText = "role"
			colrole.Name = "colrole"
			dataGridView1.Columns.Add(colrole)
			Dim colstate As System.Windows.Forms.DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
			colstate.DataPropertyName = "state"
			colstate.HeaderText = "state"
			colstate.Name = "colstate"
			dataGridView1.Columns.Add(colstate)
			Dim colschool As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			colschool.DataPropertyName = "school"
			colschool.HeaderText = "school"
			colschool.Name = "colschool"
			dataGridView1.Columns.Add(colschool)
			Dim colstatus As System.Windows.Forms.DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
			colstatus.DataPropertyName = "status"
			colstatus.HeaderText = "status"
			colstatus.Name = "colstatus"
			dataGridView1.Columns.Add(colstatus)
			Me.dataGridView1.DataSource = Me.oauth_usersBindingSource
		End Sub
		
		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			oauth_usersBindingSource.EndEdit()
			ad.Update(Me.newDataSet.oauth_users)
		End Sub
		
		Private Sub frmoauth_users_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub
		
		Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)
			
			Dim s As String
			Dim row As DataGridViewRow= dataGridView1.Rows(e.RowIndex)
			Dim value As Object = e.FormattedValue
			e.Cancel = False
			row.ErrorText = ""
			If row.IsNewRow Then
				Return
			End If
			If e.ColumnIndex = 0 Then
				
				Dim v as Integer
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field user_id is required"
					Return
				End If
				s = value.ToString()
				If Not Integer.TryParse( s, v ) Then
					e.Cancel = True
					row.ErrorText = "The field user_id must be Integer."
					Return
				End If
			End If
			If e.ColumnIndex = 1 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field username is required"
					Return
				End If
			End If
			If e.ColumnIndex = 2 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field password is required"
					Return
				End If
			End If
			If e.ColumnIndex = 3 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field first_name is required"
					Return
				End If
			End If
			If e.ColumnIndex = 4 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field last_name is required"
					Return
				End If
			End If
			If e.ColumnIndex = 5 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field email is required"
					Return
				End If
			End If
			If e.ColumnIndex = 6 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field role is required"
					Return
				End If
			End If
			If e.ColumnIndex = 8 Then
				
				If (TypeOf value is DBNull) OrElse String.IsNullOrEmpty( value.ToString() ) Then 
					e.Cancel = True
					row.ErrorText = "The field school is required"
					Return
				End If
			End If
		End Sub
		Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
			dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
			e.Cancel = true
		End Sub
		
		Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs)
			oauth_usersBindingSource.AddNew()
		End Sub
		
	End Class
	
End Namespace
