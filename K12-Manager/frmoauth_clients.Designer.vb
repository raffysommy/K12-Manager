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
	
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
	Partial Class frmoauth_clients
		Inherits System.Windows.Forms.Form
		
		'Form overrides dispose to clean up the component list.
		<System.Diagnostics.DebuggerNonUserCode()> _
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
			Finally
			MyBase.Dispose(disposing)
			End Try
		End Sub
		
		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer
		
		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmoauth_clients))
			Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
			Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
			Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
			Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
			Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
			Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
			Me.Panel1 = New System.Windows.Forms.Panel()
			
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.newDataSet = New NewDataSet()
			Me.oauth_clientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			
			CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.BindingNavigator1.SuspendLayout()
			CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.oauth_clientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			'
			'BindingNavigator1
			'
			Me.BindingNavigator1.AddNewItem = Nothing
			Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
			Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
			Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
			Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
			Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
			Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
			Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
			Me.BindingNavigator1.Name = "BindingNavigator1"
			Me.bindingNavigator1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
			Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
			Me.BindingNavigator1.Size = New System.Drawing.Size(400, 25)
			Me.BindingNavigator1.TabIndex = 0
			Me.BindingNavigator1.Text = "BindingNavigator1"
			'
			'BindingNavigatorAddNewItem
			'
			Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
			Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorAddNewItem.Text = "Add new"
			AddHandler Me.BindingNavigatorAddNewItem.Click, AddressOf Me.bindingNavigatorAddNewItem_Click
			'
			'BindingNavigatorCountItem
			'
			Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
			Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
			Me.BindingNavigatorCountItem.Text = "of {0}"
			Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
			'
			'BindingNavigatorDeleteItem
			'
			Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
			Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorDeleteItem.Text = "Delete"
			'
			'BindingNavigatorMoveFirstItem
			'
			Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
			Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorMoveFirstItem.Text = "Move first"
			'
			'BindingNavigatorMovePreviousItem
			'
			Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
			Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
			'
			'BindingNavigatorSeparator
			'
			Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
			Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
			'
			'BindingNavigatorPositionItem
			'
			Me.BindingNavigatorPositionItem.AccessibleName = "Position"
			Me.BindingNavigatorPositionItem.AutoSize = False
			Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
			Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
			Me.BindingNavigatorPositionItem.Text = "0"
			Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
			'
			'BindingNavigatorSeparator1
			'
			Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
			Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
			'
			'BindingNavigatorMoveNextItem
			'
			Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
			Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorMoveNextItem.Text = "Move next"
			'
			'BindingNavigatorMoveLastItem
			'
			Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
			Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
			Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
			Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
			Me.BindingNavigatorMoveLastItem.Text = "Move last"
			'
			'BindingNavigatorSeparator2
			'
			Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
			Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
			'
			'ToolStripButton1
			'
			Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
			Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.ToolStripButton1.Name = "ToolStripButton1"
			Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
			Me.ToolStripButton1.Text = "Save"
			'
			'ErrorProvider1
			'
			Me.ErrorProvider1.ContainerControl = Me
			'
			'Panel1
			'
			Me.Panel1.AutoScroll = True
			Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Panel1.Location = New System.Drawing.Point(0, 25)
			Me.Panel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New System.Drawing.Size(656, 183)
			Me.Panel1.TabIndex = 1
			Me.Panel1.AutoSize = True
			
			Me.bindingNavigator1.BindingSource = Me.oauth_clientsBindingSource
			'
			'newDataSet
			' 
			Me.newDataSet.DataSetName = "NewDataSet"
			Me.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			'
			'tableBindingSource
			' 
			Me.oauth_clientsBindingSource.DataMember = "oauth_clients"
			Me.oauth_clientsBindingSource.DataSource = Me.newDataSet
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(9, 37)
			Me.dataGridView1.Name = "dataGridView1" 
			Me.dataGridView1.Size = New System.Drawing.Size(339, 261)
			Me.dataGridView1.TabIndex = 0
			AddHandler Me.dataGridView1.CellValidating, AddressOf Me.dataGridView1_CellValidating
			AddHandler Me.dataGridView1.DataError, AddressOf Me.dataGridView1_DataError
			Me.Panel1.Controls.Add(Me.dataGridView1)
			
			'
			'frmoauth_clients
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(400, 359)
			Me.Name = "frmoauth_clients"
			Me.Text = "frmoauth_clients"
			CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.BindingNavigator1.ResumeLayout(False)
			Me.BindingNavigator1.PerformLayout()
			CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Text = "Oauth_Clients"
			Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
			Me.Controls.Add(Me.Panel1)
			CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.oauth_clientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			
			Me.Controls.Add(Me.BindingNavigator1)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
			
		End Sub
		Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
		Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
		Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
		Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
		Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
		Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
		Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
		Friend WithEvents Panel1 As System.Windows.Forms.Panel
		Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
		Friend WithEvents newDataSet As NewDataSet
		Friend WithEvents oauth_clientsBindingSource As System.Windows.Forms.BindingSource
		
	End Class
	
End Namespace
