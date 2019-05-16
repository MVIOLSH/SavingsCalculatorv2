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
        Me.txtwage = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNIC = New System.Windows.Forms.TextBox()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.txtNetIncome = New System.Windows.Forms.TextBox()
        Me.btnCalcWage = New System.Windows.Forms.Button()
        Me.DtExpenses = New System.Windows.Forms.DataGridView()
        Me.Expense_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clac = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblHowMuch = New System.Windows.Forms.Label()
        Me.lblExpense = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txtExpenseName = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSavings = New System.Windows.Forms.TextBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DtExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtwage
        '
        Me.txtwage.Location = New System.Drawing.Point(168, 38)
        Me.txtwage.Name = "txtwage"
        Me.txtwage.Size = New System.Drawing.Size(100, 20)
        Me.txtwage.TabIndex = 0
        Me.txtwage.Text = "0"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Annual", "Monthly", "Weekly"})
        Me.cmbType.Location = New System.Drawing.Point(18, 37)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(115, 21)
        Me.cmbType.TabIndex = 1
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(15, 21)
        Me.lblChoice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(78, 13)
        Me.lblChoice.TabIndex = 2
        Me.lblChoice.Text = "Please Choose"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(166, 21)
        Me.lblSalary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(67, 13)
        Me.lblSalary.TabIndex = 3
        Me.lblSalary.Text = "Your Income"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(309, 21)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(312, 38)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(42, 20)
        Me.txtTax.TabIndex = 4
        Me.txtTax.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NI Contrib."
        '
        'txtNIC
        '
        Me.txtNIC.Location = New System.Drawing.Point(396, 37)
        Me.txtNIC.Name = "txtNIC"
        Me.txtNIC.ReadOnly = True
        Me.txtNIC.Size = New System.Drawing.Size(56, 20)
        Me.txtNIC.TabIndex = 6
        Me.txtNIC.Text = "0"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Location = New System.Drawing.Point(480, 20)
        Me.lblNetIncome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(87, 13)
        Me.lblNetIncome.TabIndex = 9
        Me.lblNetIncome.Text = "Your Net Income"
        '
        'txtNetIncome
        '
        Me.txtNetIncome.Location = New System.Drawing.Point(483, 37)
        Me.txtNetIncome.Name = "txtNetIncome"
        Me.txtNetIncome.ReadOnly = True
        Me.txtNetIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtNetIncome.TabIndex = 8
        Me.txtNetIncome.Text = "0"
        '
        'btnCalcWage
        '
        Me.btnCalcWage.Location = New System.Drawing.Point(648, 37)
        Me.btnCalcWage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcWage.Name = "btnCalcWage"
        Me.btnCalcWage.Size = New System.Drawing.Size(76, 21)
        Me.btnCalcWage.TabIndex = 10
        Me.btnCalcWage.Text = "Calculate"
        Me.btnCalcWage.UseVisualStyleBackColor = True
        '
        'DtExpenses
        '
        Me.DtExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtExpenses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Expense_Name, Me.Amount, Me.Percent, Me.Clac})
        Me.DtExpenses.Location = New System.Drawing.Point(312, 87)
        Me.DtExpenses.Margin = New System.Windows.Forms.Padding(2)
        Me.DtExpenses.Name = "DtExpenses"
        Me.DtExpenses.RowTemplate.Height = 33
        Me.DtExpenses.Size = New System.Drawing.Size(412, 204)
        Me.DtExpenses.TabIndex = 11
        '
        'Expense_Name
        '
        Me.Expense_Name.HeaderText = "Expense Name"
        Me.Expense_Name.Name = "Expense_Name"
        Me.Expense_Name.Width = 150
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 80
        '
        'Percent
        '
        Me.Percent.HeaderText = "% of all Expenses"
        Me.Percent.Name = "Percent"
        Me.Percent.Width = 80
        '
        'Clac
        '
        Me.Clac.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Clac.HeaderText = "Calulate Percent"
        Me.Clac.Name = "Clac"
        Me.Clac.Text = "Press"
        Me.Clac.ToolTipText = "Press this button to calculate percent"
        Me.Clac.UseColumnTextForButtonValue = True
        Me.Clac.Width = 60
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(192, 144)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 21)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add Expense"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblHowMuch
        '
        Me.lblHowMuch.AutoSize = True
        Me.lblHowMuch.Location = New System.Drawing.Point(166, 87)
        Me.lblHowMuch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowMuch.Name = "lblHowMuch"
        Me.lblHowMuch.Size = New System.Drawing.Size(98, 13)
        Me.lblHowMuch.TabIndex = 16
        Me.lblHowMuch.Text = "How much you pay"
        '
        'lblExpense
        '
        Me.lblExpense.AutoSize = True
        Me.lblExpense.Location = New System.Drawing.Point(15, 87)
        Me.lblExpense.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpense.Name = "lblExpense"
        Me.lblExpense.Size = New System.Drawing.Size(118, 13)
        Me.lblExpense.TabIndex = 15
        Me.lblExpense.Text = "Please specify expense"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(168, 104)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 13
        Me.txtAmount.Text = "0"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 450)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'txtExpenseName
        '
        Me.txtExpenseName.Location = New System.Drawing.Point(18, 104)
        Me.txtExpenseName.Name = "txtExpenseName"
        Me.txtExpenseName.Size = New System.Drawing.Size(115, 20)
        Me.txtExpenseName.TabIndex = 18
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(609, 304)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(115, 20)
        Me.txtTotal.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(480, 308)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(116, 16)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Expenses Total"
        '
        'txtSavings
        '
        Me.txtSavings.Location = New System.Drawing.Point(609, 351)
        Me.txtSavings.Name = "txtSavings"
        Me.txtSavings.ReadOnly = True
        Me.txtSavings.Size = New System.Drawing.Size(115, 20)
        Me.txtSavings.TabIndex = 22
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(480, 355)
        Me.lblSavings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(100, 16)
        Me.lblSavings.TabIndex = 21
        Me.lblSavings.Text = "Your Savings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 390)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 21)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Calc Savings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtExpenseName)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.lblHowMuch)
        Me.Controls.Add(Me.lblExpense)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DtExpenses)
        Me.Controls.Add(Me.btnCalcWage)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.txtNetIncome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNIC)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtwage)
        Me.Name = "Form1"
        Me.Text = "Savings Calculator v2.0"
        CType(Me.DtExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtwage As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblChoice As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNIC As TextBox
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents txtNetIncome As TextBox
    Friend WithEvents btnCalcWage As Button
    Friend WithEvents DtExpenses As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblHowMuch As Label
    Friend WithEvents lblExpense As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents txtExpenseName As TextBox
    Friend WithEvents Expense_Name As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Percent As DataGridViewTextBoxColumn
    Friend WithEvents Clac As DataGridViewButtonColumn
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtSavings As TextBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents Button1 As Button
End Class
