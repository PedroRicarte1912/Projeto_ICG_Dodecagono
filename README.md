# Projeção 2D de Icosaedro Interativo — Computação Gráfica

Aplicação desktop desenvolvida em **C#** utilizando **Windows Forms** para a disciplina de **Introdução à Computação Gráfica**. O objetivo do projeto é renderizar a projeção 2D de um icosaedro com fidelidade visual, permitindo a personalização de cores das faces visíveis e transformações geométricas em tempo real.

---

## 📌 Funcionalidades

- **Renderização da Projeção 2D de Icosaedro**:
  - Definição programática da estrutura de vértices, arestas e faces.
  - Desenho preciso mantendo as proporções, ângulos e o contorno hexagonal da projeção.
  
- **Mosaico de Cores Interativo**:
  - Grid de opções de cores para seleção.
  - Identificação e estilização individual das **10 faces triangulares visíveis**[cite: 1].
  - Alteração de cor por meio do clique do usuário na face correspondente[cite: 1].

- **Transformações Geométricas 2D (TrackBars)**:
  - **Translação no Eixo X e Y**: Controles deslizantes para movimentação contínua do objeto pela tela[cite: 1].
  - **Escala Uniforme**: Controle deslizante para redimensionamento do icosaedro a partir de seu ponto central[cite: 1].

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#[cite: 1]
- **Framework GUI**: Windows Forms (.NET)[cite: 1]
- **Biblioteca Gráfica**: `System.Drawing` / GDI+ (utilização de primitivas de desenho)[cite: 1]

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
- Visual Studio 2022 (com a carga de trabalho **Desenvolvimento para Desktop com .NET** instalada).
- SDK do .NET compatível com a solução.

### Passos
1. Clone o repositório em sua máquina local:
   ```bash
   git clone [https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/seu-usuario/nome-do-repositorio.git)
