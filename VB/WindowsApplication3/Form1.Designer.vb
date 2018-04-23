Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.checkButton1 = New DevExpress.XtraEditors.CheckButton()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.textEdit3)
			Me.layoutControl1.Controls.Add(Me.checkButton1)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Controls.Add(Me.memoEdit1)
			Me.layoutControl1.Controls.Add(Me.textEdit2)
			Me.layoutControl1.Controls.Add(Me.textEdit1)
			Me.layoutControl1.Controls.Add(Me.dateEdit1)
			Me.layoutControl1.Controls.Add(Me.calcEdit1)
			Me.layoutControl1.Controls.Add(Me.buttonEdit1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(548, 475)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
'			Me.layoutControl1.ShowContextMenu += New DevExpress.XtraLayout.LayoutMenuEventHandler(Me.OnLayoutControlShowContextMenu);
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(388, 46)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(136, 22)
			Me.buttonEdit1.StyleController = Me.layoutControl1
			Me.buttonEdit1.TabIndex = 4
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2, Me.layoutControlGroup3})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(548, 475)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.buttonEdit1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(252, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(252, 26)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(108, 16)
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			Me.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG"
			Me.openFileDialog1.InitialDirectory = "C:\Users\Public\Pictures "
			Me.openFileDialog1.RestoreDirectory = True
			' 
			' calcEdit1
			' 
			Me.calcEdit1.Location = New System.Drawing.Point(136, 46)
			Me.calcEdit1.Name = "calcEdit1"
			Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcEdit1.Size = New System.Drawing.Size(136, 22)
			Me.calcEdit1.StyleController = Me.layoutControl1
			Me.calcEdit1.TabIndex = 5
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.calcEdit1
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(252, 26)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(108, 16)
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = Nothing
			Me.dateEdit1.Location = New System.Drawing.Point(388, 72)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(136, 22)
			Me.dateEdit1.StyleController = Me.layoutControl1
			Me.dateEdit1.TabIndex = 6
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.dateEdit1
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
			Me.layoutControlItem3.Location = New System.Drawing.Point(252, 26)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(252, 26)
			Me.layoutControlItem3.Text = "layoutControlItem3"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(108, 16)
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(136, 72)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(136, 22)
			Me.textEdit1.StyleController = Me.layoutControl1
			Me.textEdit1.TabIndex = 7
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.textEdit1
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 26)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(252, 26)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(108, 16)
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(136, 171)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(388, 22)
			Me.textEdit2.StyleController = Me.layoutControl1
			Me.textEdit2.TabIndex = 8
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.textEdit2
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 27)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(504, 26)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(108, 16)
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(136, 197)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(388, 228)
			Me.memoEdit1.StyleController = Me.layoutControl1
			Me.memoEdit1.TabIndex = 9
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.memoEdit1
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(0, 53)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(504, 232)
			Me.layoutControlItem6.Text = "layoutControlItem6"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(108, 16)
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem2, Me.layoutControlItem1, Me.layoutControlItem3})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(528, 98)
			Me.layoutControlGroup2.Text = "layoutControlGroup2"
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 98)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(528, 357)
			Me.layoutControlGroup3.Text = "layoutControlGroup3"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(24, 144)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(248, 23)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 10
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.simpleButton1
			Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
			Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(252, 27)
			Me.layoutControlItem7.Text = "layoutControlItem7"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextToControlDistance = 0
			Me.layoutControlItem7.TextVisible = False
			' 
			' checkButton1
			' 
			Me.checkButton1.Location = New System.Drawing.Point(276, 144)
			Me.checkButton1.Name = "checkButton1"
			Me.checkButton1.Size = New System.Drawing.Size(248, 23)
			Me.checkButton1.StyleController = Me.layoutControl1
			Me.checkButton1.TabIndex = 11
			Me.checkButton1.Text = "checkButton1"
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.checkButton1
			Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
			Me.layoutControlItem8.Location = New System.Drawing.Point(252, 0)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(252, 27)
			Me.layoutControlItem8.Text = "layoutControlItem8"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextToControlDistance = 0
			Me.layoutControlItem8.TextVisible = False
			' 
			' textEdit3
			' 
			Me.textEdit3.Location = New System.Drawing.Point(136, 429)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(388, 22)
			Me.textEdit3.StyleController = Me.layoutControl1
			Me.textEdit3.TabIndex = 12
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.textEdit3
			Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
			Me.layoutControlItem9.Location = New System.Drawing.Point(0, 285)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(504, 26)
			Me.layoutControlItem9.Text = "layoutControlItem9"
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(108, 16)
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 475)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.calcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private calcEdit1 As DevExpress.XtraEditors.CalcEdit
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private checkButton1 As DevExpress.XtraEditors.CheckButton
		Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

