<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gridComanda = New System.Windows.Forms.DataGridView()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.txtComanda = New System.Windows.Forms.TextBox()
        Me.lblNomeComanda = New System.Windows.Forms.Label()
        Me.cboTipoProduto = New System.Windows.Forms.ComboBox()
        Me.pnItens = New System.Windows.Forms.Panel()
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.nmQtde = New System.Windows.Forms.NumericUpDown()
        Me.btnInserirItem = New System.Windows.Forms.Button()
        Me.btnRemoverItem = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDescricaoProduto = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblTipoProduto = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTotalComanda = New System.Windows.Forms.Label()
        Me.btnCancelarComanda = New System.Windows.Forms.Button()
        Me.btnReceberComanda = New System.Windows.Forms.Button()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridItens = New System.Windows.Forms.DataGridView()
        CType(Me.gridComanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnItens.SuspendLayout()
        CType(Me.nmQtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridComanda
        '
        Me.gridComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridComanda.Location = New System.Drawing.Point(12, 448)
        Me.gridComanda.Name = "gridComanda"
        Me.gridComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridComanda.Size = New System.Drawing.Size(755, 336)
        Me.gridComanda.TabIndex = 0
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.LightBlue
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.Location = New System.Drawing.Point(16, 381)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(93, 47)
        Me.btnInserir.TabIndex = 1
        Me.btnInserir.Text = "Inserir Comanda"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'txtComanda
        '
        Me.txtComanda.Location = New System.Drawing.Point(29, 54)
        Me.txtComanda.Name = "txtComanda"
        Me.txtComanda.Size = New System.Drawing.Size(207, 20)
        Me.txtComanda.TabIndex = 2
        '
        'lblNomeComanda
        '
        Me.lblNomeComanda.AutoSize = True
        Me.lblNomeComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeComanda.Location = New System.Drawing.Point(26, 38)
        Me.lblNomeComanda.Name = "lblNomeComanda"
        Me.lblNomeComanda.Size = New System.Drawing.Size(95, 13)
        Me.lblNomeComanda.TabIndex = 3
        Me.lblNomeComanda.Text = "Nome Comanda"
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.FormattingEnabled = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(26, 32)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Size = New System.Drawing.Size(159, 21)
        Me.cboTipoProduto.TabIndex = 4
        '
        'pnItens
        '
        Me.pnItens.Controls.Add(Me.gridItens)
        Me.pnItens.Controls.Add(Me.txtValorTotal)
        Me.pnItens.Controls.Add(Me.Label1)
        Me.pnItens.Controls.Add(Me.lblQtde)
        Me.pnItens.Controls.Add(Me.nmQtde)
        Me.pnItens.Controls.Add(Me.btnInserirItem)
        Me.pnItens.Controls.Add(Me.btnRemoverItem)
        Me.pnItens.Controls.Add(Me.txtValor)
        Me.pnItens.Controls.Add(Me.txtDescricaoProduto)
        Me.pnItens.Controls.Add(Me.lblValor)
        Me.pnItens.Controls.Add(Me.lblDescricao)
        Me.pnItens.Controls.Add(Me.lblTipoProduto)
        Me.pnItens.Controls.Add(Me.cboTipoProduto)
        Me.pnItens.Location = New System.Drawing.Point(384, 21)
        Me.pnItens.Name = "pnItens"
        Me.pnItens.Size = New System.Drawing.Size(383, 421)
        Me.pnItens.TabIndex = 5
        Me.pnItens.Visible = False
        '
        'lblQtde
        '
        Me.lblQtde.AutoSize = True
        Me.lblQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtde.Location = New System.Drawing.Point(27, 129)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(72, 13)
        Me.lblQtde.TabIndex = 12
        Me.lblQtde.Text = "Quantidade"
        '
        'nmQtde
        '
        Me.nmQtde.Location = New System.Drawing.Point(30, 145)
        Me.nmQtde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmQtde.Name = "nmQtde"
        Me.nmQtde.Size = New System.Drawing.Size(81, 20)
        Me.nmQtde.TabIndex = 11
        Me.nmQtde.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnInserirItem
        '
        Me.btnInserirItem.BackColor = System.Drawing.Color.LightBlue
        Me.btnInserirItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserirItem.Location = New System.Drawing.Point(168, 187)
        Me.btnInserirItem.Name = "btnInserirItem"
        Me.btnInserirItem.Size = New System.Drawing.Size(100, 49)
        Me.btnInserirItem.TabIndex = 14
        Me.btnInserirItem.Text = "Inserir Item"
        Me.btnInserirItem.UseVisualStyleBackColor = False
        '
        'btnRemoverItem
        '
        Me.btnRemoverItem.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemoverItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverItem.Location = New System.Drawing.Point(274, 187)
        Me.btnRemoverItem.Name = "btnRemoverItem"
        Me.btnRemoverItem.Size = New System.Drawing.Size(93, 49)
        Me.btnRemoverItem.TabIndex = 15
        Me.btnRemoverItem.Text = "Remover Item"
        Me.btnRemoverItem.UseVisualStyleBackColor = False
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(129, 145)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(110, 20)
        Me.txtValor.TabIndex = 10
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(26, 85)
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(341, 20)
        Me.txtDescricaoProduto.TabIndex = 9
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(126, 129)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(74, 13)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor (Unid)"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.Location = New System.Drawing.Point(23, 69)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(64, 13)
        Me.lblDescricao.TabIndex = 7
        Me.lblDescricao.Text = "Descrição"
        '
        'lblTipoProduto
        '
        Me.lblTipoProduto.AutoSize = True
        Me.lblTipoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoProduto.Location = New System.Drawing.Point(23, 16)
        Me.lblTipoProduto.Name = "lblTipoProduto"
        Me.lblTipoProduto.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoProduto.TabIndex = 6
        Me.lblTipoProduto.Text = "Tipo Produto"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(29, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 13
        '
        'lblTotalComanda
        '
        Me.lblTotalComanda.AutoSize = True
        Me.lblTotalComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalComanda.Location = New System.Drawing.Point(26, 105)
        Me.lblTotalComanda.Name = "lblTotalComanda"
        Me.lblTotalComanda.Size = New System.Drawing.Size(92, 13)
        Me.lblTotalComanda.TabIndex = 13
        Me.lblTotalComanda.Text = "Valor Comanda"
        '
        'btnCancelarComanda
        '
        Me.btnCancelarComanda.BackColor = System.Drawing.Color.IndianRed
        Me.btnCancelarComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarComanda.Location = New System.Drawing.Point(288, 381)
        Me.btnCancelarComanda.Name = "btnCancelarComanda"
        Me.btnCancelarComanda.Size = New System.Drawing.Size(90, 47)
        Me.btnCancelarComanda.TabIndex = 16
        Me.btnCancelarComanda.Text = "Excluir Comanda"
        Me.btnCancelarComanda.UseVisualStyleBackColor = False
        '
        'btnReceberComanda
        '
        Me.btnReceberComanda.BackColor = System.Drawing.Color.LightGreen
        Me.btnReceberComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceberComanda.Location = New System.Drawing.Point(152, 381)
        Me.btnReceberComanda.Name = "btnReceberComanda"
        Me.btnReceberComanda.Size = New System.Drawing.Size(93, 47)
        Me.btnReceberComanda.TabIndex = 17
        Me.btnReceberComanda.Text = "Receber Comanda"
        Me.btnReceberComanda.UseVisualStyleBackColor = False
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtValorTotal.Location = New System.Drawing.Point(254, 145)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(113, 20)
        Me.txtValorTotal.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Valor Total"
        '
        'gridItens
        '
        Me.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItens.Location = New System.Drawing.Point(3, 242)
        Me.gridItens.Name = "gridItens"
        Me.gridItens.Size = New System.Drawing.Size(377, 176)
        Me.gridItens.TabIndex = 18
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 796)
        Me.Controls.Add(Me.btnReceberComanda)
        Me.Controls.Add(Me.btnCancelarComanda)
        Me.Controls.Add(Me.lblTotalComanda)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.pnItens)
        Me.Controls.Add(Me.lblNomeComanda)
        Me.Controls.Add(Me.txtComanda)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.gridComanda)
        Me.Name = "frmMain"
        Me.Text = "Formulário Comandas"
        CType(Me.gridComanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnItens.ResumeLayout(False)
        Me.pnItens.PerformLayout()
        CType(Me.nmQtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridComanda As DataGridView
    Friend WithEvents btnInserir As Button
    Friend WithEvents txtComanda As TextBox
    Friend WithEvents lblNomeComanda As Label
    Friend WithEvents cboTipoProduto As ComboBox
    Friend WithEvents pnItens As Panel
    Friend WithEvents lblQtde As Label
    Friend WithEvents nmQtde As NumericUpDown
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDescricaoProduto As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblTipoProduto As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTotalComanda As Label
    Friend WithEvents btnInserirItem As Button
    Friend WithEvents btnRemoverItem As Button
    Friend WithEvents btnCancelarComanda As Button
    Friend WithEvents btnReceberComanda As Button
    Friend WithEvents gridItens As DataGridView
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents Label1 As Label
End Class
