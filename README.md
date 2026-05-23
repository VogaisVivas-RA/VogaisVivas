# Vogais Vivas - Alfabetização Baseada em Realidade Aumentada (AR) 📱✨

O **Vogais Vivas** é um ecossistema educacional imersivo em Realidade Aumentada projetado para transformar o processo de alfabetização infantil em uma jornada lúdica, interativa e altamente engajadora. Através do uso de marcadores físicos e dispositivos móveis, o projeto dá vida às vogais do alfabeto, estimulando a associação fonética e visual de crianças em fase de letramento.

---

## 🎓 Contexto Acadêmico & Equipe

Este projeto foi desenvolvido como parte integrante das atividades acadêmicas da disciplina **Optativa - Introdução a Sistemas Virtuais e Aumentados 2026/1** no curso de **Tecnologia em Sistemas para Internet (TSI)** do **Instituto Federal de Brasília (IFB) - Campus Brasília**.

### 👥 Desenvolvedores (Estudantes do IFB)
* **Felipe Dias Santana** — *Estudante de Sistemas para Internet & Desenvolvedor Unity/C#*
* **Suellen Maciel Dutra** — *Estudante de Sistemas para Internet & Pesquisadora/Desenvolvedora*

### 👨‍🏫 Orientação e Corpo Docente (IFB)
* **Dr. Lázaro Vinícius de Oliveira Lima** — *Professor Orientador / IFB*
* **Dra. Cristiane Jorge de Lima Bonfim** — *Professora Orientadora / IFB*

### 🧪 Validação Pedagógica e Prática
* **Cecília Martins Costa** — *Pedagoga da Secretaria de Estado de Educação do Distrito Federal (SEEDF)*
    * *Responsável pela validação metodológica, adequação à BNCC e testes de usabilidade com o público-alvo infantil.*

---

## 📝 Publicações Científicas

O referencial teórico, a metodologia e a estrutura deste ecossistema foram submetidos, aceitos e publicados formalmente:

* **Trabalho:** Resumo Expandido
* **Título Oficial:** *PROJETO VOGAIS VIVAS: APLICAÇÃO DE REALIDADE AUMENTADA MULTIMODAL PARA AUXÍLIO NA ALFABETIZAÇÃO INFANTIL*
* **Evento:** III Simpósio de Integração, Inovação e Tecnologia (SIIT) - Instituto Federal de Brasília (IFB), 2026.
* **Autores:** Suellen Maciel Dutra, Felipe Dias Santana, Lázaro Vinícius de Oliveira Lima, Cristiane Jorge de Lima Bonfim.
* **Acesso ao documento:** O arquivo PDF completo do resumo aceito está disponível para consulta na pasta `docs/` deste repositório.

---

## 🎯 O Projeto

O aplicativo utiliza a câmera do celular para ler cartões impressos das vogais (**A, E, I, O, U**). Ao reconhecer o marcador, o sistema projeta na tela da criança a respectiva letra em 3D, cercada por uma identidade visual *low-poly* colorida e animada. 

Para reforçar o aprendizado, animais associados a cada vogal (como a **Ovelha**, o **Urso** e a **Iguana**) realizam órbitas dinâmicas ao redor da letra, interagindo através de animações de caminhada controladas em tempo real.

### Principais Funcionalidades:
* **Reconhecimento Estável:** Rastreamento preciso através do motor computacional do Vuforia.
* **Órbitas Matemáticas com C#:** Lógica aplicada que mantém os animais caminhando ao redor do eixo central da letra em raio controlado, sem perda de orientação (*Root Motion* tratado).
* **Otimização para Dispositivos Móveis:** Texturas mapeadas e reduzidas na densidade de pixels ideal (1k/2k) para garantir alta taxa de quadros (FPS), evitando aquecimento do aparelho ou travamentos em sala de aula.

---

## 🛠️ Stack Tecnológica

O ambiente de desenvolvimento foi projetado para garantir escalabilidade e consistência entre a equipe de desenvolvimento:

* **Game Engine:** Unity 6
* **SDK de Realidade Aumentada:** Vuforia Engine (v11.4.4)
* **Linguagem de Programação:** C# (Scripts de translação, rotação orbital e gerenciamento de estados)
* **Controle de Versão:** Git + GitHub Desktop
* **Infraestrutura de Repositório:** Configurado com suporte nativo a **Git LFS (Large File Storage)** via arquivo de propriedades customizado (`.gitattributes`), permitindo o versionamento de modelos e texturas tridimensionais pesadas sem perda de performance.

---

## 📁 Estrutura Básica do Repositório

* `/Assets`: Scripts C#, Modelos 3D, Controladores de Animação e Materiais.
* `/Packages`: Dependências e o motor central do Vuforia Engine.
* `/.gitattributes`: Configurações de filtros Git LFS para compressões pesadas (`*.tgz`).
* `/docs`: Documentações do projeto e artigos científicos publicados.

---

## 🚀 Como Executar o Projeto Localmente

1. Certifique-se de ter o **Unity Hub** instalado e a versão correspondente do Unity 6.
2. Clone este repositório utilizando o GitHub Desktop ou terminal (certifique-se de ter o Git LFS instalado na sua máquina):
```bash
   git clone [https://github.com/VogaisVivas-RA/VogaisVivas.git](https://github.com/VogaisVivas-RA/VogaisVivas.git)
