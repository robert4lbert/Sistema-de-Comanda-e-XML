Imports System.Drawing.Printing
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class frmMain
    Private Property clsFuncoes As New clsFuncoes
    Private Property xmlComanda As New clsXML
    Private Property xComanda As New clsComandas
    Private Property Lista As New List(Of clsComandas)
    Private Property ListaItem As New List(Of clsComandas)
    Private Property ComandaSelecionada As Integer

    Public Sub Load()
        ' Criar uma instância da classe
        Lista = New List(Of clsComandas)


        ' Definir a origem de dados do ComboBox como a lista de objetos Item
        cboTipoProduto.DataSource = clsFuncoes.ObterProdutos()

        ' Definir as propriedades de exibição do ComboBox
        cboTipoProduto.DisplayMember = "Produto"
        cboTipoProduto.ValueMember = "Produto"
    End Sub
    Public Sub addListaPrincipal(listaADD As clsComandas)
        Lista.Add(listaADD)
    End Sub
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Load()
    End Sub


    Public Sub CriarComanda()
        Try
            If txtComanda.Text = "" Then
                clsFuncoes.TratarErro("Informe um nome para a Comanda")
                Exit Sub
            End If
            Dim newComanda = xComanda.CriarComanda(txtComanda.Text)

            addListaPrincipal(newComanda)
            clsFuncoes.PreencherGridView(Lista, gridComanda)
            xmlComanda.SerializarLista(Lista)
        Catch ex As Exception
            ' Tratar exceção, se necessário
        End Try
    End Sub






#Region "Eventos Principal"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCriarComanda_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            CriarComanda()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gridComanda_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridComanda.CellMouseClick
        Try
            ComandaSelecionada = CInt(gridComanda.SelectedCells(0).Value)
            If ComandaSelecionada > 0 Then
                HabilitarItens()
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region





    'Itens
    Private Sub HabilitarItens()
        Try
            pnItens.Visible = True
            txtValorTotal.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcularValorTotal()
        Try
            txtValorTotal.Text = Convert.ToDouble(nmQtde.Value * CDbl(txtValor.Text)).ToString("#.00")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub addItensComanda()
        Try
            If txtDescricaoProduto.Text = "" AndAlso txtValor.Text = "" Then
                clsFuncoes.TratarErro("Preencher os dados antes de inserir")
                Exit Sub
            End If

            xComanda.AddItem(cboTipoProduto.SelectedItem.PRODUTO, txtDescricaoProduto.Text, nmQtde.Value, txtValor.Text)
            Dim newComandaItem = xComanda
            addListaPrincipal(newComandaItem)
            clsFuncoes.PreencherGridViewItem(Lista, gridComanda)
            xmlComanda.SerializarLista(Lista)

        Catch ex As Exception

        End Try
    End Sub

#Region "Eventos Itens"
    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Try
            CalcularValorTotal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInserirItem_Click(sender As Object, e As EventArgs) Handles btnInserirItem.Click
        Try

            addItensComanda()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnRemoverItem_Click(sender As Object, e As EventArgs) Handles btnRemoverItem.Click
        Try



        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class



