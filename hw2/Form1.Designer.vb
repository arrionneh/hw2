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
        Me.components = New System.ComponentModel.Container()
        Me.lblPayrollCalc = New System.Windows.Forms.Label()
        Me.lblPaycheckCalc = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbldecFICA = New System.Windows.Forms.Label()
        Me.lbldecFed = New System.Windows.Forms.Label()
        Me.lbldecState = New System.Windows.Forms.Label()
        Me.lbldecNet = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPayrollCalc
        '
        Me.lblPayrollCalc.AutoSize = True
        Me.lblPayrollCalc.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollCalc.Location = New System.Drawing.Point(451, 68)
        Me.lblPayrollCalc.Name = "lblPayrollCalc"
        Me.lblPayrollCalc.Size = New System.Drawing.Size(312, 36)
        Me.lblPayrollCalc.TabIndex = 0
        Me.lblPayrollCalc.Text = "Payroll Calculator"
        '
        'lblPaycheckCalc
        '
        Me.lblPaycheckCalc.AutoSize = True
        Me.lblPaycheckCalc.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheckCalc.Location = New System.Drawing.Point(451, 163)
        Me.lblPaycheckCalc.Name = "lblPaycheckCalc"
        Me.lblPaycheckCalc.Size = New System.Drawing.Size(309, 31)
        Me.lblPaycheckCalc.TabIndex = 1
        Me.lblPaycheckCalc.Text = "Paycheck Calculation"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.hw2.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 221)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.Color.Black
        Me.btnTaxCalc.Location = New System.Drawing.Point(81, 285)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(142, 37)
        Me.btnTaxCalc.TabIndex = 3
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(352, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 37)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(592, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(226, 239)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(135, 23)
        Me.lblGrossPay.TabIndex = 6
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(77, 354)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(42, 20)
        Me.lblFICA.TabIndex = 7
        Me.lblFICA.Text = "FICA: "
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.Location = New System.Drawing.Point(348, 355)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(83, 20)
        Me.lblFederal.TabIndex = 8
        Me.lblFederal.Text = "Federal Tax:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(577, 354)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(72, 20)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "State Tax: "
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(252, 403)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(155, 20)
        Me.lblIncome.TabIndex = 10
        Me.lblIncome.Text = "Net Paycheck Income: "
        '
        'txtIncome
        '
        Me.txtIncome.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.Location = New System.Drawing.Point(379, 239)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(123, 27)
        Me.txtIncome.TabIndex = 11
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lbldecFICA
        '
        Me.lbldecFICA.AutoSize = True
        Me.lbldecFICA.Location = New System.Drawing.Point(147, 361)
        Me.lbldecFICA.Name = "lbldecFICA"
        Me.lbldecFICA.Size = New System.Drawing.Size(0, 13)
        Me.lbldecFICA.TabIndex = 12
        '
        'lbldecFed
        '
        Me.lbldecFed.AutoSize = True
        Me.lbldecFed.Location = New System.Drawing.Point(457, 355)
        Me.lbldecFed.Name = "lbldecFed"
        Me.lbldecFed.Size = New System.Drawing.Size(0, 13)
        Me.lbldecFed.TabIndex = 13
        '
        'lbldecState
        '
        Me.lbldecState.AutoSize = True
        Me.lbldecState.Location = New System.Drawing.Point(672, 355)
        Me.lbldecState.Name = "lbldecState"
        Me.lbldecState.Size = New System.Drawing.Size(0, 13)
        Me.lbldecState.TabIndex = 14
        '
        'lbldecNet
        '
        Me.lbldecNet.AutoSize = True
        Me.lbldecNet.Location = New System.Drawing.Point(424, 409)
        Me.lbldecNet.Name = "lbldecNet"
        Me.lbldecNet.Size = New System.Drawing.Size(0, 13)
        Me.lbldecNet.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbldecNet)
        Me.Controls.Add(Me.lbldecState)
        Me.Controls.Add(Me.lbldecFed)
        Me.Controls.Add(Me.lbldecFICA)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPaycheckCalc)
        Me.Controls.Add(Me.lblPayrollCalc)
        Me.Name = "Form1"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPayrollCalc As Label
    Friend WithEvents lblPaycheckCalc As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lbldecFICA As Label
    Friend WithEvents lbldecFed As Label
    Friend WithEvents lbldecState As Label
    Friend WithEvents lbldecNet As Label
End Class
