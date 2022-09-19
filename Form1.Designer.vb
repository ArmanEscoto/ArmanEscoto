<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.lastname = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.middlename = New System.Windows.Forms.Label()
        Me.txtmiddle = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.Label()
        Me.contact = New System.Windows.Forms.Label()
        Me.course = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Listview1 = New System.Windows.Forms.ListView()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.btnAddnewStud = New System.Windows.Forms.Button()
        Me.btnUpdateStud = New System.Windows.Forms.Button()
        Me.btnDeleteStud = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID."
        '
        'txtSID
        '
        Me.txtSID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSID.Location = New System.Drawing.Point(129, 31)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(610, 20)
        Me.txtSID.TabIndex = 1
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(102, 79)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(69, 15)
        Me.lastname.TabIndex = 2
        Me.lastname.Text = "Last Name"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(337, 79)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(72, 15)
        Me.firstname.TabIndex = 3
        Me.firstname.Text = "First Name"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.Location = New System.Drawing.Point(54, 107)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(215, 20)
        Me.txtlastname.TabIndex = 4
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.Location = New System.Drawing.Point(293, 107)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(207, 20)
        Me.txtfirstname.TabIndex = 5
        '
        'middlename
        '
        Me.middlename.AutoSize = True
        Me.middlename.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.Location = New System.Drawing.Point(605, 79)
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(82, 14)
        Me.middlename.TabIndex = 6
        Me.middlename.Text = "Midlle Initial"
        '
        'txtmiddle
        '
        Me.txtmiddle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmiddle.Location = New System.Drawing.Point(524, 107)
        Me.txtmiddle.Name = "txtmiddle"
        Me.txtmiddle.Size = New System.Drawing.Size(215, 20)
        Me.txtmiddle.TabIndex = 7
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(54, 143)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(52, 15)
        Me.address.TabIndex = 8
        Me.address.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(54, 161)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(685, 20)
        Me.txtaddress.TabIndex = 9
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(102, 197)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(48, 15)
        Me.gender.TabIndex = 10
        Me.gender.Text = "Gender"
        '
        'contact
        '
        Me.contact.AutoSize = True
        Me.contact.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(337, 197)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(74, 15)
        Me.contact.TabIndex = 11
        Me.contact.Text = "Contact No."
        '
        'course
        '
        Me.course.AutoSize = True
        Me.course.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course.Location = New System.Drawing.Point(605, 197)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(45, 15)
        Me.course.TabIndex = 12
        Me.course.Text = "Course"
        '
        'txtcontact
        '
        Me.txtcontact.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontact.Location = New System.Drawing.Point(293, 226)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(207, 20)
        Me.txtcontact.TabIndex = 14
        '
        'cmbcourse
        '
        Me.cmbcourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BSIT", "BSTM", "BSCRIM", "BSBA"})
        Me.cmbcourse.Location = New System.Drawing.Point(524, 225)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(215, 21)
        Me.cmbcourse.TabIndex = 15
        '
        'Listview1
        '
        Me.Listview1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Listview1.HideSelection = False
        Me.Listview1.Location = New System.Drawing.Point(57, 262)
        Me.Listview1.Name = "Listview1"
        Me.Listview1.Size = New System.Drawing.Size(697, 176)
        Me.Listview1.TabIndex = 16
        Me.Listview1.UseCompatibleStateImageBehavior = False
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(51, 226)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(212, 21)
        Me.cmbgender.TabIndex = 17
        '
        'btnAddnewStud
        '
        Me.btnAddnewStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddnewStud.Location = New System.Drawing.Point(310, 486)
        Me.btnAddnewStud.Name = "btnAddnewStud"
        Me.btnAddnewStud.Size = New System.Drawing.Size(117, 33)
        Me.btnAddnewStud.TabIndex = 18
        Me.btnAddnewStud.Text = "ADD NEW"
        Me.btnAddnewStud.UseVisualStyleBackColor = False
        '
        'btnUpdateStud
        '
        Me.btnUpdateStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateStud.Location = New System.Drawing.Point(454, 486)
        Me.btnUpdateStud.Name = "btnUpdateStud"
        Me.btnUpdateStud.Size = New System.Drawing.Size(111, 33)
        Me.btnUpdateStud.TabIndex = 19
        Me.btnUpdateStud.Text = "UPDATE"
        Me.btnUpdateStud.UseVisualStyleBackColor = False
        '
        'btnDeleteStud
        '
        Me.btnDeleteStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDeleteStud.Location = New System.Drawing.Point(646, 486)
        Me.btnDeleteStud.Name = "btnDeleteStud"
        Me.btnDeleteStud.Size = New System.Drawing.Size(102, 33)
        Me.btnDeleteStud.TabIndex = 20
        Me.btnDeleteStud.Text = "DELETE"
        Me.btnDeleteStud.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(861, 545)
        Me.Controls.Add(Me.btnDeleteStud)
        Me.Controls.Add(Me.btnUpdateStud)
        Me.Controls.Add(Me.btnAddnewStud)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.Listview1)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.txtmiddle)
        Me.Controls.Add(Me.middlename)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.txtSID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSID As TextBox
    Friend WithEvents lastname As Label
    Friend WithEvents firstname As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents middlename As Label
    Friend WithEvents txtmiddle As TextBox
    Friend WithEvents address As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents gender As Label
    Friend WithEvents contact As Label
    Friend WithEvents course As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents Listview1 As ListView
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents btnAddnewStud As Button
    Friend WithEvents btnUpdateStud As Button
    Friend WithEvents btnDeleteStud As Button
End Class
