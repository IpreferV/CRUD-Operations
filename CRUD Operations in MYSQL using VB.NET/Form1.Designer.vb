<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        text_productNo = New TextBox()
        text_productName = New TextBox()
        text_productPrice = New TextBox()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        btn_Save = New Button()
        btn_Edit = New Button()
        btn_Delete = New Button()
        btn_Clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        text_productGroup = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' text_productNo
        ' 
        text_productNo.Location = New Point(45, 36)
        text_productNo.Name = "text_productNo"
        text_productNo.Size = New Size(195, 23)
        text_productNo.TabIndex = 0
        ' 
        ' text_productName
        ' 
        text_productName.Location = New Point(45, 91)
        text_productName.Name = "text_productName"
        text_productName.Size = New Size(195, 23)
        text_productName.TabIndex = 0
        ' 
        ' text_productPrice
        ' 
        text_productPrice.Location = New Point(45, 135)
        text_productPrice.Name = "text_productPrice"
        text_productPrice.Size = New Size(195, 23)
        text_productPrice.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(45, 179)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(195, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(45, 226)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(45, 274)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(74, 19)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Available"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = Color.ForestGreen
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_Save.ForeColor = Color.White
        btn_Save.Location = New Point(45, 299)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(104, 39)
        btn_Save.TabIndex = 4
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' btn_Edit
        ' 
        btn_Edit.BackColor = Color.Goldenrod
        btn_Edit.FlatStyle = FlatStyle.Flat
        btn_Edit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_Edit.ForeColor = Color.White
        btn_Edit.Location = New Point(150, 299)
        btn_Edit.Name = "btn_Edit"
        btn_Edit.Size = New Size(104, 39)
        btn_Edit.TabIndex = 4
        btn_Edit.Text = "Update"
        btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' btn_Delete
        ' 
        btn_Delete.BackColor = Color.Firebrick
        btn_Delete.FlatStyle = FlatStyle.Flat
        btn_Delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_Delete.ForeColor = Color.White
        btn_Delete.Location = New Point(45, 339)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(104, 39)
        btn_Delete.TabIndex = 4
        btn_Delete.Text = "Delete"
        btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' btn_Clear
        ' 
        btn_Clear.BackColor = SystemColors.ControlDarkDark
        btn_Clear.FlatStyle = FlatStyle.Flat
        btn_Clear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btn_Clear.ForeColor = Color.White
        btn_Clear.Location = New Point(150, 339)
        btn_Clear.Name = "btn_Clear"
        btn_Clear.Size = New Size(104, 39)
        btn_Clear.TabIndex = 4
        btn_Clear.Text = "Clear"
        btn_Clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 5
        Label1.Text = "Product Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 5
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 5
        Label3.Text = "Price"
        ' 
        ' text_productGroup
        ' 
        text_productGroup.AutoSize = True
        text_productGroup.Location = New Point(45, 161)
        text_productGroup.Name = "text_productGroup"
        text_productGroup.Size = New Size(85, 15)
        text_productGroup.TabIndex = 5
        text_productGroup.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 5
        Label5.Text = "Expiration Date"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(777, 392)
        Controls.Add(Label5)
        Controls.Add(text_productGroup)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Clear)
        Controls.Add(btn_Delete)
        Controls.Add(btn_Edit)
        Controls.Add(btn_Save)
        Controls.Add(CheckBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(text_productPrice)
        Controls.Add(text_productName)
        Controls.Add(text_productNo)
        Cursor = Cursors.Hand
        Name = "Form1"
        Text = "CRUD Operations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents text_productNo As TextBox
    Friend WithEvents text_productName As TextBox
    Friend WithEvents text_productPrice As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents text_productGroup As Label
    Friend WithEvents Label5 As Label

End Class
