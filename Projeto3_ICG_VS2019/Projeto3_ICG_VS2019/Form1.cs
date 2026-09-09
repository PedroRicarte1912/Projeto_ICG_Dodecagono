/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 11 / 09 / 2026
 * Autores do Projeto: Pedro Ricarte Gisler
    Júlia Carolina Maciel
 *
 * Turma: 3F
 * Projeto 3 de ICG - Mosaico de Triângulos
 * Observação: 
 * 
 * 
 * ******************************************************************/
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projeto3_TESTE_ICG
{
    public partial class Form1 : Form
    {
        #region Campos

        // Cor atualmente selecionada pelo usuário nos botões do mosaico
        private Color corSelecionada = Cor(0, 0, 0);

        // Array para armazenar a cor individual de cada um dos 10 triângulos (padrão: Branco)
        private Color[] coresTriangulos = new Color[10];

        // ── Estado das transformações controladas pelas TrackBars ──────────────
        private int deslocamentoX = 0;    // Translação no eixo X (pixels)
        private int deslocamentoY = 0;    // Translação no eixo Y (pixels)
        private float fatorEscala = 1.0f; // Escala (1.0 = tamanho original)

        // Valores-base do desenho (antes de aplicar translação/escala)
        private const int RAIO_BASE = 150;
        private const int OFFSET_X_BASE = 100; // Desloca o desenho p/ direita, abrindo espaço para os botões

        // Definição dos triângulos para uso no Paint e no clique do Mouse
        private int[][] triangulos = new int[][]
        {
            // Triângulos externos (conectando borda ao triângulo interno)
            new int[] {0, 1, 7},
            new int[] {1, 2, 7},
            new int[] {2, 3, 6},
            new int[] {3, 4, 6},
            new int[] {4, 5, 8},
            new int[] {5, 0, 8},

            // Triângulos intermediários (fechando as pontas internas)
            new int[] {0, 7, 8},
            new int[] {2, 6, 7},
            new int[] {4, 6, 8},

            // Triângulo central
            new int[] {6, 7, 8}
        };

        #endregion

        #region Construtor

        public Form1()
        {
            InitializeComponent();

            // Configurações do Form para evitar iluminação excessiva/flicker
            this.DoubleBuffered = true;

            // Associação dos eventos em substituição aos métodos sobrescritos (override)
            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;

            // Inicializa todos os triângulos com cor de fundo branca
            for (int i = 0; i < coresTriangulos.Length; i++)
            {
                coresTriangulos[i] = Cor(255, 255, 255);
            }
        }

        #endregion

        #region Primitivas

        public static Color Cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

        public Pen Caneta(Color cor, int espessura)
        {
            return new Pen(cor, espessura);
        }

        #endregion

        #region Eventos de seleção de cor (mosaico)

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_cor_1_Click(object sender, EventArgs e)
        {
            corSelecionada = Cor(255, 0, 0); // Vermelho
        }

        private void btn_cor_2_Click(object sender, EventArgs e)
        {
            corSelecionada = Cor(0, 255, 0); // Verde
        }

        private void btn_cor_3_Click(object sender, EventArgs e)
        {
            corSelecionada = Cor(0, 0, 255); // Azul
        }

        private void btn_cor_rosa_Click(object sender, EventArgs e)
        {
            corSelecionada = Cor(255, 192, 203); // Rosa
        }

        private void btn_cor_5_Click(object sender, EventArgs e)
        {
            corSelecionada = Cor(255, 255, 0); // Amarelo
        }
        private void btn_cor_6_Click_1(object sender, EventArgs e)
        {
            corSelecionada = Cor(128, 0, 128); // Roxo
        }

        private void btn_cor_7_Click_1(object sender, EventArgs e)
        {
            corSelecionada = Cor(0, 255, 127); // Verde Água
        }

        private void btn_cor_8_Click_1(object sender, EventArgs e)
        {
            corSelecionada = Cor(255, 140, 0); // Laranja
        }

        private void btn_cor_9_Click_1(object sender, EventArgs e)
        {
            corSelecionada = Cor(139, 69, 19); // Marrom
        }

        private void btn_cor_10_Click_1(object sender, EventArgs e)
        {
            corSelecionada = Cor(255, 105, 180); // Rosa Choque
        }

        // Restaura todos os triângulos para a cor branca original
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < coresTriangulos.Length; i++)
            {
                coresTriangulos[i] = Cor(255, 255, 255);
            }

            Invalidate();
        }

        #endregion

        #region Desenho (Paint)

        // Evento de pintura da tela (sem usar protected override)
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Usa os métodos auxiliares para garantir que Paint e MouseClick
            // sempre usem exatamente a mesma posição/tamanho atual
            int centroX = ObterCentroX();
            int centroY = ObterCentroY();
            int raio = ObterRaioAtual();

            DesenharIcosaedro2D(e.Graphics, centroX, centroY, raio);
        }

        public void DesenharIcosaedro2D(Graphics g, int xc, int yc, int raio)
        {
            Pen caneta = Caneta(Cor(0, 0, 0), 2);

            // Obtenção dos vértices calculados
            PointF[] todosPontos = ObterPontosIcosaedro(xc, yc, raio);

            // Preenchimento e desenho de cada triângulo
            for (int i = 0; i < triangulos.Length; i++)
            {
                int[] t = triangulos[i];
                PointF[] pts = new PointF[]
                {
                    todosPontos[t[0]],
                    todosPontos[t[1]],
                    todosPontos[t[2]]
                };

                // 1. Preenchimento (Pintura) da face do triângulo com SolidBrush
                using (SolidBrush pincel = new SolidBrush(coresTriangulos[i]))
                {
                    g.FillPolygon(pincel, pts);
                }

                // 2. Desenho do contorno
                g.DrawPolygon(caneta, pts);
            }
        }

        #endregion

        #region Clique do mouse (seleção de face)

        // Evento que detecta o clique do mouse 
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Mesmos valores usados no Paint — nunca duplicar o cálculo aqui,
            // senão o clique pode detectar a face na posição errada após mover/escalar
            int centroX = ObterCentroX();
            int centroY = ObterCentroY();
            int raio = ObterRaioAtual();

            PointF[] todosPontos = ObterPontosIcosaedro(centroX, centroY, raio);

            // Verifica qual triângulo foi atingido pelo clique (teste manual, sem GraphicsPath)
            for (int i = 0; i < triangulos.Length; i++)
            {
                int[] t = triangulos[i];
                PointF p0 = todosPontos[t[0]];
                PointF p1 = todosPontos[t[1]];
                PointF p2 = todosPontos[t[2]];

                if (PontoDentroDoTriangulo(e.Location, p0, p1, p2))
                {
                    coresTriangulos[i] = corSelecionada; // Aplica a cor reservada no mosaico
                    this.Invalidate(); // Força a tela a redesenhar com a nova cor
                    break;
                }
            }
        }

        #endregion

        #region Transformações (TrackBars) — Requisito 3 do projeto

        // Translação no eixo X
        private void trkTranslacaoX_Scroll(object sender, EventArgs e)
        {
            deslocamentoX = trkTranslacaoX.Value;
            Invalidate();
        }

        // Translação no eixo Y
        private void trkTranslacaoY_Scroll(object sender, EventArgs e)
        {
            deslocamentoY = trkTranslacaoY.Value;
            Invalidate();
        }

        // Escala (redimensiona em relação ao centro, pois o centro nunca muda,
        // apenas o raio usado para calcular os vértices)
        private void trkEscala_Scroll(object sender, EventArgs e)
        {
            // O TrackBar trabalha com inteiros (ex: 50 a 200) -> convertido para fator 0.5 a 2.0
            fatorEscala = trkEscala.Value / 100f;
            Invalidate();
        }

        #endregion

        #region Métodos auxiliares

        // Centro X atual = base do form + offset fixo + translação do TrackBar
        private int ObterCentroX()
        {
            return this.ClientSize.Width / 2 + OFFSET_X_BASE + deslocamentoX;
        }

        // Centro Y atual = centro do form + translação do TrackBar
        private int ObterCentroY()
        {
            return this.ClientSize.Height / 2 + deslocamentoY;
        }

        // Raio atual = raio base ajustado pelo fator de escala do TrackBar
        private int ObterRaioAtual()
        {
            return (int)(RAIO_BASE * fatorEscala);
        }

        // Método auxiliar para calcular os pontos e evitar duplicação de código
        private PointF[] ObterPontosIcosaedro(int xc, int yc, int raio)
        {
            float cos30 = (float)Math.Cos(Math.PI / 6);
            float sin30 = (float)Math.Sin(Math.PI / 6);

            PointF[] pontos = new PointF[9];

            // Vértices do Hexágono Externo (0 a 5)
            pontos[0] = new PointF(xc, yc - raio);
            pontos[1] = new PointF(xc + raio * cos30, yc - raio * sin30);
            pontos[2] = new PointF(xc + raio * cos30, yc + raio * sin30);
            pontos[3] = new PointF(xc, yc + raio);
            pontos[4] = new PointF(xc - raio * cos30, yc + raio * sin30);
            pontos[5] = new PointF(xc - raio * cos30, yc - raio * sin30);

            // Vértices do Triângulo Interno (6 a 8)
            int rInt = raio / 2;
            pontos[6] = new PointF(xc, yc + rInt);
            pontos[7] = new PointF(xc + rInt * cos30, yc - rInt * sin30);
            pontos[8] = new PointF(xc - rInt * cos30, yc - rInt * sin30);

            return pontos;
        }

        // ── Teste manual: o ponto p está do lado esquerdo ou direito da reta a→b? ──
        // Calcula o "sinal" via produto vetorial (cross product) de (p-b) e (a-b).
        // Resultado positivo, negativo ou zero indica de que lado do segmento o ponto está.
        private float Sinal(PointF p, PointF a, PointF b)
        {
            return (p.X - b.X) * (a.Y - b.Y) - (a.X - b.X) * (p.Y - b.Y);
        }

        // ── Teste manual: o ponto p está dentro do triângulo (v0, v1, v2)? ──
        // Aplica o teste de sinal nas 3 arestas do triângulo. Se o ponto estiver
        // sempre do mesmo lado (todos os sinais com o mesmo sinal, ou zero),
        // ele está dentro do triângulo. Substitui o GraphicsPath.IsVisible do .NET
        // por um cálculo geométrico feito manualmente.
        private bool PontoDentroDoTriangulo(Point p, PointF v0, PointF v1, PointF v2)
        {
            float d1 = Sinal(p, v0, v1);
            float d2 = Sinal(p, v1, v2);
            float d3 = Sinal(p, v2, v0);

            bool temNegativo = (d1 < 0) || (d2 < 0) || (d3 < 0);
            bool temPositivo = (d1 > 0) || (d2 > 0) || (d3 > 0);

            // Se não houver mistura de sinais positivos e negativos, o ponto está dentro
            return !(temNegativo && temPositivo);
        }

        #endregion

        
    }
}