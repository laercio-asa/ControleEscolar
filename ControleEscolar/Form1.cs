using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
  public partial class FrmMedia : Form
  {
    public FrmMedia()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      // Aqui é um comentário
      // criando as variaveis
      // boa pratica criar as variaveis no começo do codigo
      decimal nota1;
      decimal nota2, nota3;
      decimal nota4 = decimal.Parse(txtN4.Text);
      decimal media1, media2, mediaFinal;
      // o C# é case sensitive, faz diferenciação entre maiusculo e minusculo
      // Parse = transformar, neste caso em decimal
      nota1 = decimal.Parse(txtN1.Text);
      nota2 = decimal.Parse(txtN2.Text);
      nota3 = decimal.Parse(txtN3.Text);
      // Fazer validação dos numeros
      // para tomar uma decisão usamos o comando if (se)
      /* 
       if é sempre uma comparação
       tipos de comparações:
       == igualdade
       >= 
       <=
       >
       <
       != diferente
       || (o nome deste simbolo é pipe) significa OU
       && significa E
      */
      if (nota1 > 10 || nota1 < 0) {
        // só para colocar o cursor na caixinha que esta com erro
        txtN1.Focus();
        // mostrar mensagem para o usuario
        MessageBox.Show("A nota 1 está errada, notas entre 0 e 10","Erro Nota 1",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        // finalizar o código, quando aparece o return o código é finalizado.
        return;
      }
      if (nota2 > 10 || nota2 < 0)
      {
        // só para colocar o cursor na caixinha que esta com erro
        txtN2.Focus();
        // mostrar mensagem para o usuario
        MessageBox.Show("A nota 2 está errada, notas entre 0 e 10", "Erro Nota 2",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        // finalizar o código, quando aparece o return o código é finalizado.
        return;
      }
      // calculo das médias
      media1 = ((nota1 * 4) + (nota2 * 6)) / 10;
      media2 = ((nota3 * 4) + (nota4 * 6)) / 10;
      mediaFinal = (media1 + media2) / 2;
      // mostrar as médias
      // .ToString() = transformar em texto isto é um método/função
      // como saber se é um método, icone do cubo roxo
      txtBim1.Text = media1.ToString("0.00");
      txtBim2.Text = media2.ToString("0.00");
      txtMedia.Text = mediaFinal.ToString("0.00");

    }

    private void txtID_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
