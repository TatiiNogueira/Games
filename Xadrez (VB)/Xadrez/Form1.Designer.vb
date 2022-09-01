<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lb_Tempo = New System.Windows.Forms.Label()
        Me.Iniciar_Pretas = New System.Windows.Forms.CheckBox()
        Me.Iniciar_Brancas = New System.Windows.Forms.CheckBox()
        Me.Pecas_Brancas = New System.Windows.Forms.Label()
        Me.Pecas_Pretas = New System.Windows.Forms.Label()
        Me.lb_Vitoriasb = New System.Windows.Forms.Label()
        Me.lb_Vitoriasp = New System.Windows.Forms.Label()
        Me.txt_Jogador2 = New System.Windows.Forms.TextBox()
        Me.txt_Jogador1 = New System.Windows.Forms.TextBox()
        Me.l_jogador_2 = New System.Windows.Forms.Label()
        Me.l_jogador_1 = New System.Windows.Forms.Label()
        Me.torre_branco_1 = New System.Windows.Forms.Button()
        Me.torre_preto_1 = New System.Windows.Forms.Button()
        Me.peao_branco_1 = New System.Windows.Forms.Button()
        Me.peao_preto_1 = New System.Windows.Forms.Button()
        Me.Cavalo1p = New System.Windows.Forms.Button()
        Me.Bispo1p = New System.Windows.Forms.Button()
        Me.Reip = New System.Windows.Forms.Button()
        Me.Rainhap = New System.Windows.Forms.Button()
        Me.Bispo2p = New System.Windows.Forms.Button()
        Me.Cavalo2p = New System.Windows.Forms.Button()
        Me.Cavalo1b = New System.Windows.Forms.Button()
        Me.Bispo1b = New System.Windows.Forms.Button()
        Me.Reib = New System.Windows.Forms.Button()
        Me.Rainhab = New System.Windows.Forms.Button()
        Me.Bispo2b = New System.Windows.Forms.Button()
        Me.Cavalo2b = New System.Windows.Forms.Button()
        Me.Torre1b = New System.Windows.Forms.Button()
        Me.Torre2p = New System.Windows.Forms.Button()
        Me.Torre1p = New System.Windows.Forms.Button()
        Me.Peao1b = New System.Windows.Forms.Button()
        Me.Peao2b = New System.Windows.Forms.Button()
        Me.Peao3b = New System.Windows.Forms.Button()
        Me.Peao4b = New System.Windows.Forms.Button()
        Me.Peao5b = New System.Windows.Forms.Button()
        Me.Peao6b = New System.Windows.Forms.Button()
        Me.Peao7b = New System.Windows.Forms.Button()
        Me.Peao8b = New System.Windows.Forms.Button()
        Me.Peao3p = New System.Windows.Forms.Button()
        Me.Peao4p = New System.Windows.Forms.Button()
        Me.Peao5p = New System.Windows.Forms.Button()
        Me.Peao6p = New System.Windows.Forms.Button()
        Me.Peao7p = New System.Windows.Forms.Button()
        Me.Peao8p = New System.Windows.Forms.Button()
        Me.Peao2p = New System.Windows.Forms.Button()
        Me.Peao1p = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Pausa = New System.Windows.Forms.Button()
        Me.btn_Novo_Jogo = New System.Windows.Forms.Button()
        Me.btn_Limpar_Resultados = New System.Windows.Forms.Button()
        Me.btn_Partida = New System.Windows.Forms.Button()
        Me.mostrar_jogadas = New System.Windows.Forms.CheckBox()
        Me.Torre2b = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_Tempo
        '
        Me.lb_Tempo.AutoSize = True
        Me.lb_Tempo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_Tempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Tempo.ForeColor = System.Drawing.Color.Green
        Me.lb_Tempo.Location = New System.Drawing.Point(754, 244)
        Me.lb_Tempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_Tempo.Name = "lb_Tempo"
        Me.lb_Tempo.Size = New System.Drawing.Size(55, 24)
        Me.lb_Tempo.TabIndex = 92
        Me.lb_Tempo.Text = "02:00"
        Me.lb_Tempo.Visible = False
        '
        'Iniciar_Pretas
        '
        Me.Iniciar_Pretas.AutoSize = True
        Me.Iniciar_Pretas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Iniciar_Pretas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iniciar_Pretas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Iniciar_Pretas.Location = New System.Drawing.Point(738, 122)
        Me.Iniciar_Pretas.Margin = New System.Windows.Forms.Padding(2)
        Me.Iniciar_Pretas.Name = "Iniciar_Pretas"
        Me.Iniciar_Pretas.Size = New System.Drawing.Size(154, 22)
        Me.Iniciar_Pretas.TabIndex = 91
        Me.Iniciar_Pretas.Text = "Iniciar peças pretas"
        Me.Iniciar_Pretas.UseVisualStyleBackColor = False
        '
        'Iniciar_Brancas
        '
        Me.Iniciar_Brancas.AutoSize = True
        Me.Iniciar_Brancas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Iniciar_Brancas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iniciar_Brancas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Iniciar_Brancas.Location = New System.Drawing.Point(740, 476)
        Me.Iniciar_Brancas.Margin = New System.Windows.Forms.Padding(2)
        Me.Iniciar_Brancas.Name = "Iniciar_Brancas"
        Me.Iniciar_Brancas.Size = New System.Drawing.Size(166, 22)
        Me.Iniciar_Brancas.TabIndex = 90
        Me.Iniciar_Brancas.Text = "Iniciar peças brancas"
        Me.Iniciar_Brancas.UseVisualStyleBackColor = False
        '
        'Pecas_Brancas
        '
        Me.Pecas_Brancas.AutoSize = True
        Me.Pecas_Brancas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pecas_Brancas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pecas_Brancas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Pecas_Brancas.Location = New System.Drawing.Point(737, 421)
        Me.Pecas_Brancas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Pecas_Brancas.Name = "Pecas_Brancas"
        Me.Pecas_Brancas.Size = New System.Drawing.Size(109, 18)
        Me.Pecas_Brancas.TabIndex = 89
        Me.Pecas_Brancas.Text = "Peças Brancas"
        '
        'Pecas_Pretas
        '
        Me.Pecas_Pretas.AutoSize = True
        Me.Pecas_Pretas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pecas_Pretas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pecas_Pretas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Pecas_Pretas.Location = New System.Drawing.Point(737, 50)
        Me.Pecas_Pretas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Pecas_Pretas.Name = "Pecas_Pretas"
        Me.Pecas_Pretas.Size = New System.Drawing.Size(97, 18)
        Me.Pecas_Pretas.TabIndex = 88
        Me.Pecas_Pretas.Text = "Peças Pretas"
        '
        'lb_Vitoriasb
        '
        Me.lb_Vitoriasb.AutoSize = True
        Me.lb_Vitoriasb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_Vitoriasb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Vitoriasb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_Vitoriasb.Location = New System.Drawing.Point(737, 456)
        Me.lb_Vitoriasb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_Vitoriasb.Name = "lb_Vitoriasb"
        Me.lb_Vitoriasb.Size = New System.Drawing.Size(78, 18)
        Me.lb_Vitoriasb.TabIndex = 87
        Me.lb_Vitoriasb.Text = "Vitórias - 0"
        '
        'lb_Vitoriasp
        '
        Me.lb_Vitoriasp.AutoSize = True
        Me.lb_Vitoriasp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lb_Vitoriasp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Vitoriasp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lb_Vitoriasp.Location = New System.Drawing.Point(737, 80)
        Me.lb_Vitoriasp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_Vitoriasp.Name = "lb_Vitoriasp"
        Me.lb_Vitoriasp.Size = New System.Drawing.Size(78, 18)
        Me.lb_Vitoriasp.TabIndex = 86
        Me.lb_Vitoriasp.Text = "Vitórias - 0"
        '
        'txt_Jogador2
        '
        Me.txt_Jogador2.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_Jogador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Jogador2.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_Jogador2.Location = New System.Drawing.Point(831, 381)
        Me.txt_Jogador2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Jogador2.MaxLength = 12
        Me.txt_Jogador2.Name = "txt_Jogador2"
        Me.txt_Jogador2.Size = New System.Drawing.Size(150, 28)
        Me.txt_Jogador2.TabIndex = 85
        '
        'txt_Jogador1
        '
        Me.txt_Jogador1.BackColor = System.Drawing.SystemColors.InfoText
        Me.txt_Jogador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Jogador1.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_Jogador1.Location = New System.Drawing.Point(831, 9)
        Me.txt_Jogador1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Jogador1.MaxLength = 12
        Me.txt_Jogador1.Name = "txt_Jogador1"
        Me.txt_Jogador1.Size = New System.Drawing.Size(150, 28)
        Me.txt_Jogador1.TabIndex = 84
        '
        'l_jogador_2
        '
        Me.l_jogador_2.AutoSize = True
        Me.l_jogador_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_jogador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_jogador_2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.l_jogador_2.Location = New System.Drawing.Point(736, 383)
        Me.l_jogador_2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_jogador_2.Name = "l_jogador_2"
        Me.l_jogador_2.Size = New System.Drawing.Size(94, 24)
        Me.l_jogador_2.TabIndex = 83
        Me.l_jogador_2.Text = "Jogador 2"
        '
        'l_jogador_1
        '
        Me.l_jogador_1.AutoSize = True
        Me.l_jogador_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.l_jogador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_jogador_1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.l_jogador_1.Location = New System.Drawing.Point(736, 11)
        Me.l_jogador_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_jogador_1.Name = "l_jogador_1"
        Me.l_jogador_1.Size = New System.Drawing.Size(94, 24)
        Me.l_jogador_1.TabIndex = 82
        Me.l_jogador_1.Text = "Jogador 1"
        '
        'torre_branco_1
        '
        Me.torre_branco_1.BackColor = System.Drawing.Color.Transparent
        Me.torre_branco_1.Image = CType(resources.GetObject("torre_branco_1.Image"), System.Drawing.Image)
        Me.torre_branco_1.Location = New System.Drawing.Point(-86, 245)
        Me.torre_branco_1.Margin = New System.Windows.Forms.Padding(2)
        Me.torre_branco_1.Name = "torre_branco_1"
        Me.torre_branco_1.Padding = New System.Windows.Forms.Padding(1)
        Me.torre_branco_1.Size = New System.Drawing.Size(72, 78)
        Me.torre_branco_1.TabIndex = 69
        Me.torre_branco_1.UseVisualStyleBackColor = False
        '
        'torre_preto_1
        '
        Me.torre_preto_1.BackColor = System.Drawing.Color.Transparent
        Me.torre_preto_1.Image = CType(resources.GetObject("torre_preto_1.Image"), System.Drawing.Image)
        Me.torre_preto_1.Location = New System.Drawing.Point(-86, -20)
        Me.torre_preto_1.Margin = New System.Windows.Forms.Padding(2)
        Me.torre_preto_1.Name = "torre_preto_1"
        Me.torre_preto_1.Padding = New System.Windows.Forms.Padding(1)
        Me.torre_preto_1.Size = New System.Drawing.Size(72, 78)
        Me.torre_preto_1.TabIndex = 66
        Me.torre_preto_1.UseVisualStyleBackColor = False
        '
        'peao_branco_1
        '
        Me.peao_branco_1.BackColor = System.Drawing.Color.Transparent
        Me.peao_branco_1.Image = CType(resources.GetObject("peao_branco_1.Image"), System.Drawing.Image)
        Me.peao_branco_1.Location = New System.Drawing.Point(-86, 162)
        Me.peao_branco_1.Margin = New System.Windows.Forms.Padding(2)
        Me.peao_branco_1.Name = "peao_branco_1"
        Me.peao_branco_1.Size = New System.Drawing.Size(72, 78)
        Me.peao_branco_1.TabIndex = 65
        Me.peao_branco_1.UseVisualStyleBackColor = False
        '
        'peao_preto_1
        '
        Me.peao_preto_1.BackColor = System.Drawing.Color.Transparent
        Me.peao_preto_1.Image = CType(resources.GetObject("peao_preto_1.Image"), System.Drawing.Image)
        Me.peao_preto_1.Location = New System.Drawing.Point(-86, 63)
        Me.peao_preto_1.Margin = New System.Windows.Forms.Padding(2)
        Me.peao_preto_1.Name = "peao_preto_1"
        Me.peao_preto_1.Padding = New System.Windows.Forms.Padding(1)
        Me.peao_preto_1.Size = New System.Drawing.Size(72, 78)
        Me.peao_preto_1.TabIndex = 50
        Me.peao_preto_1.UseVisualStyleBackColor = False
        '
        'Cavalo1p
        '
        Me.Cavalo1p.BackColor = System.Drawing.Color.Transparent
        Me.Cavalo1p.Image = CType(resources.GetObject("Cavalo1p.Image"), System.Drawing.Image)
        Me.Cavalo1p.Location = New System.Drawing.Point(91, 11)
        Me.Cavalo1p.Margin = New System.Windows.Forms.Padding(2)
        Me.Cavalo1p.Name = "Cavalo1p"
        Me.Cavalo1p.Padding = New System.Windows.Forms.Padding(1)
        Me.Cavalo1p.Size = New System.Drawing.Size(72, 78)
        Me.Cavalo1p.TabIndex = 124
        Me.Cavalo1p.UseVisualStyleBackColor = False
        '
        'Bispo1p
        '
        Me.Bispo1p.BackColor = System.Drawing.Color.Transparent
        Me.Bispo1p.Image = CType(resources.GetObject("Bispo1p.Image"), System.Drawing.Image)
        Me.Bispo1p.Location = New System.Drawing.Point(167, 11)
        Me.Bispo1p.Margin = New System.Windows.Forms.Padding(2)
        Me.Bispo1p.Name = "Bispo1p"
        Me.Bispo1p.Padding = New System.Windows.Forms.Padding(1)
        Me.Bispo1p.Size = New System.Drawing.Size(72, 78)
        Me.Bispo1p.TabIndex = 123
        Me.Bispo1p.UseVisualStyleBackColor = False
        '
        'Reip
        '
        Me.Reip.BackColor = System.Drawing.Color.Transparent
        Me.Reip.Image = CType(resources.GetObject("Reip.Image"), System.Drawing.Image)
        Me.Reip.Location = New System.Drawing.Point(250, 11)
        Me.Reip.Margin = New System.Windows.Forms.Padding(2)
        Me.Reip.Name = "Reip"
        Me.Reip.Padding = New System.Windows.Forms.Padding(1)
        Me.Reip.Size = New System.Drawing.Size(72, 78)
        Me.Reip.TabIndex = 122
        Me.Reip.UseVisualStyleBackColor = False
        '
        'Rainhap
        '
        Me.Rainhap.BackColor = System.Drawing.Color.Transparent
        Me.Rainhap.Image = CType(resources.GetObject("Rainhap.Image"), System.Drawing.Image)
        Me.Rainhap.Location = New System.Drawing.Point(329, 11)
        Me.Rainhap.Margin = New System.Windows.Forms.Padding(2)
        Me.Rainhap.Name = "Rainhap"
        Me.Rainhap.Padding = New System.Windows.Forms.Padding(1)
        Me.Rainhap.Size = New System.Drawing.Size(72, 78)
        Me.Rainhap.TabIndex = 121
        Me.Rainhap.UseVisualStyleBackColor = False
        '
        'Bispo2p
        '
        Me.Bispo2p.BackColor = System.Drawing.Color.Transparent
        Me.Bispo2p.Image = CType(resources.GetObject("Bispo2p.Image"), System.Drawing.Image)
        Me.Bispo2p.Location = New System.Drawing.Point(409, 11)
        Me.Bispo2p.Margin = New System.Windows.Forms.Padding(2)
        Me.Bispo2p.Name = "Bispo2p"
        Me.Bispo2p.Padding = New System.Windows.Forms.Padding(1)
        Me.Bispo2p.Size = New System.Drawing.Size(72, 78)
        Me.Bispo2p.TabIndex = 120
        Me.Bispo2p.UseVisualStyleBackColor = False
        '
        'Cavalo2p
        '
        Me.Cavalo2p.BackColor = System.Drawing.Color.Transparent
        Me.Cavalo2p.Image = CType(resources.GetObject("Cavalo2p.Image"), System.Drawing.Image)
        Me.Cavalo2p.Location = New System.Drawing.Point(488, 11)
        Me.Cavalo2p.Margin = New System.Windows.Forms.Padding(2)
        Me.Cavalo2p.Name = "Cavalo2p"
        Me.Cavalo2p.Padding = New System.Windows.Forms.Padding(1)
        Me.Cavalo2p.Size = New System.Drawing.Size(72, 78)
        Me.Cavalo2p.TabIndex = 119
        Me.Cavalo2p.UseVisualStyleBackColor = False
        '
        'Cavalo1b
        '
        Me.Cavalo1b.BackColor = System.Drawing.Color.Transparent
        Me.Cavalo1b.Image = CType(resources.GetObject("Cavalo1b.Image"), System.Drawing.Image)
        Me.Cavalo1b.Location = New System.Drawing.Point(88, 276)
        Me.Cavalo1b.Margin = New System.Windows.Forms.Padding(2)
        Me.Cavalo1b.Name = "Cavalo1b"
        Me.Cavalo1b.Padding = New System.Windows.Forms.Padding(1)
        Me.Cavalo1b.Size = New System.Drawing.Size(72, 78)
        Me.Cavalo1b.TabIndex = 118
        Me.Cavalo1b.UseVisualStyleBackColor = False
        '
        'Bispo1b
        '
        Me.Bispo1b.BackColor = System.Drawing.Color.Transparent
        Me.Bispo1b.Image = CType(resources.GetObject("Bispo1b.Image"), System.Drawing.Image)
        Me.Bispo1b.Location = New System.Drawing.Point(167, 276)
        Me.Bispo1b.Margin = New System.Windows.Forms.Padding(2)
        Me.Bispo1b.Name = "Bispo1b"
        Me.Bispo1b.Padding = New System.Windows.Forms.Padding(1)
        Me.Bispo1b.Size = New System.Drawing.Size(72, 78)
        Me.Bispo1b.TabIndex = 117
        Me.Bispo1b.UseVisualStyleBackColor = False
        '
        'Reib
        '
        Me.Reib.BackColor = System.Drawing.Color.Transparent
        Me.Reib.Image = CType(resources.GetObject("Reib.Image"), System.Drawing.Image)
        Me.Reib.Location = New System.Drawing.Point(250, 276)
        Me.Reib.Margin = New System.Windows.Forms.Padding(2)
        Me.Reib.Name = "Reib"
        Me.Reib.Padding = New System.Windows.Forms.Padding(1)
        Me.Reib.Size = New System.Drawing.Size(72, 78)
        Me.Reib.TabIndex = 116
        Me.Reib.UseVisualStyleBackColor = False
        '
        'Rainhab
        '
        Me.Rainhab.BackColor = System.Drawing.Color.Transparent
        Me.Rainhab.Image = CType(resources.GetObject("Rainhab.Image"), System.Drawing.Image)
        Me.Rainhab.Location = New System.Drawing.Point(326, 276)
        Me.Rainhab.Margin = New System.Windows.Forms.Padding(2)
        Me.Rainhab.Name = "Rainhab"
        Me.Rainhab.Padding = New System.Windows.Forms.Padding(1)
        Me.Rainhab.Size = New System.Drawing.Size(72, 78)
        Me.Rainhab.TabIndex = 115
        Me.Rainhab.UseVisualStyleBackColor = False
        '
        'Bispo2b
        '
        Me.Bispo2b.BackColor = System.Drawing.Color.Transparent
        Me.Bispo2b.Image = CType(resources.GetObject("Bispo2b.Image"), System.Drawing.Image)
        Me.Bispo2b.Location = New System.Drawing.Point(406, 276)
        Me.Bispo2b.Margin = New System.Windows.Forms.Padding(2)
        Me.Bispo2b.Name = "Bispo2b"
        Me.Bispo2b.Padding = New System.Windows.Forms.Padding(1)
        Me.Bispo2b.Size = New System.Drawing.Size(72, 78)
        Me.Bispo2b.TabIndex = 114
        Me.Bispo2b.UseVisualStyleBackColor = False
        '
        'Cavalo2b
        '
        Me.Cavalo2b.BackColor = System.Drawing.Color.Transparent
        Me.Cavalo2b.Image = CType(resources.GetObject("Cavalo2b.Image"), System.Drawing.Image)
        Me.Cavalo2b.Location = New System.Drawing.Point(485, 276)
        Me.Cavalo2b.Margin = New System.Windows.Forms.Padding(2)
        Me.Cavalo2b.Name = "Cavalo2b"
        Me.Cavalo2b.Padding = New System.Windows.Forms.Padding(1)
        Me.Cavalo2b.Size = New System.Drawing.Size(72, 78)
        Me.Cavalo2b.TabIndex = 113
        Me.Cavalo2b.UseVisualStyleBackColor = False
        '
        'Torre1b
        '
        Me.Torre1b.BackColor = System.Drawing.Color.Transparent
        Me.Torre1b.Image = CType(resources.GetObject("Torre1b.Image"), System.Drawing.Image)
        Me.Torre1b.Location = New System.Drawing.Point(11, 276)
        Me.Torre1b.Margin = New System.Windows.Forms.Padding(2)
        Me.Torre1b.Name = "Torre1b"
        Me.Torre1b.Padding = New System.Windows.Forms.Padding(1)
        Me.Torre1b.Size = New System.Drawing.Size(72, 78)
        Me.Torre1b.TabIndex = 112
        Me.Torre1b.UseVisualStyleBackColor = False
        '
        'Torre2p
        '
        Me.Torre2p.BackColor = System.Drawing.Color.Transparent
        Me.Torre2p.ForeColor = System.Drawing.Color.Transparent
        Me.Torre2p.Image = CType(resources.GetObject("Torre2p.Image"), System.Drawing.Image)
        Me.Torre2p.Location = New System.Drawing.Point(568, 11)
        Me.Torre2p.Margin = New System.Windows.Forms.Padding(2)
        Me.Torre2p.Name = "Torre2p"
        Me.Torre2p.Padding = New System.Windows.Forms.Padding(1)
        Me.Torre2p.Size = New System.Drawing.Size(72, 78)
        Me.Torre2p.TabIndex = 110
        Me.Torre2p.UseVisualStyleBackColor = False
        '
        'Torre1p
        '
        Me.Torre1p.BackColor = System.Drawing.Color.Transparent
        Me.Torre1p.Image = CType(resources.GetObject("Torre1p.Image"), System.Drawing.Image)
        Me.Torre1p.Location = New System.Drawing.Point(11, 11)
        Me.Torre1p.Margin = New System.Windows.Forms.Padding(2)
        Me.Torre1p.Name = "Torre1p"
        Me.Torre1p.Padding = New System.Windows.Forms.Padding(1)
        Me.Torre1p.Size = New System.Drawing.Size(72, 78)
        Me.Torre1p.TabIndex = 109
        Me.Torre1p.UseVisualStyleBackColor = False
        '
        'Peao1b
        '
        Me.Peao1b.BackColor = System.Drawing.Color.Transparent
        Me.Peao1b.Image = CType(resources.GetObject("Peao1b.Image"), System.Drawing.Image)
        Me.Peao1b.Location = New System.Drawing.Point(11, 193)
        Me.Peao1b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao1b.Name = "Peao1b"
        Me.Peao1b.Size = New System.Drawing.Size(72, 78)
        Me.Peao1b.TabIndex = 108
        Me.Peao1b.UseVisualStyleBackColor = False
        '
        'Peao2b
        '
        Me.Peao2b.BackColor = System.Drawing.Color.Transparent
        Me.Peao2b.Image = CType(resources.GetObject("Peao2b.Image"), System.Drawing.Image)
        Me.Peao2b.Location = New System.Drawing.Point(88, 193)
        Me.Peao2b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao2b.Name = "Peao2b"
        Me.Peao2b.Size = New System.Drawing.Size(75, 78)
        Me.Peao2b.TabIndex = 107
        Me.Peao2b.UseVisualStyleBackColor = False
        '
        'Peao3b
        '
        Me.Peao3b.BackColor = System.Drawing.Color.Transparent
        Me.Peao3b.Image = CType(resources.GetObject("Peao3b.Image"), System.Drawing.Image)
        Me.Peao3b.Location = New System.Drawing.Point(167, 193)
        Me.Peao3b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao3b.Name = "Peao3b"
        Me.Peao3b.Size = New System.Drawing.Size(75, 78)
        Me.Peao3b.TabIndex = 106
        Me.Peao3b.UseVisualStyleBackColor = False
        '
        'Peao4b
        '
        Me.Peao4b.BackColor = System.Drawing.Color.Transparent
        Me.Peao4b.Image = CType(resources.GetObject("Peao4b.Image"), System.Drawing.Image)
        Me.Peao4b.Location = New System.Drawing.Point(247, 193)
        Me.Peao4b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao4b.Name = "Peao4b"
        Me.Peao4b.Size = New System.Drawing.Size(75, 78)
        Me.Peao4b.TabIndex = 105
        Me.Peao4b.UseVisualStyleBackColor = False
        '
        'Peao5b
        '
        Me.Peao5b.BackColor = System.Drawing.Color.Transparent
        Me.Peao5b.Image = CType(resources.GetObject("Peao5b.Image"), System.Drawing.Image)
        Me.Peao5b.Location = New System.Drawing.Point(326, 193)
        Me.Peao5b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao5b.Name = "Peao5b"
        Me.Peao5b.Size = New System.Drawing.Size(75, 78)
        Me.Peao5b.TabIndex = 104
        Me.Peao5b.UseVisualStyleBackColor = False
        '
        'Peao6b
        '
        Me.Peao6b.BackColor = System.Drawing.Color.Transparent
        Me.Peao6b.Image = CType(resources.GetObject("Peao6b.Image"), System.Drawing.Image)
        Me.Peao6b.Location = New System.Drawing.Point(406, 193)
        Me.Peao6b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao6b.Name = "Peao6b"
        Me.Peao6b.Size = New System.Drawing.Size(75, 78)
        Me.Peao6b.TabIndex = 103
        Me.Peao6b.UseVisualStyleBackColor = False
        '
        'Peao7b
        '
        Me.Peao7b.BackColor = System.Drawing.Color.Transparent
        Me.Peao7b.Image = CType(resources.GetObject("Peao7b.Image"), System.Drawing.Image)
        Me.Peao7b.Location = New System.Drawing.Point(485, 193)
        Me.Peao7b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao7b.Name = "Peao7b"
        Me.Peao7b.Size = New System.Drawing.Size(75, 78)
        Me.Peao7b.TabIndex = 102
        Me.Peao7b.UseVisualStyleBackColor = False
        '
        'Peao8b
        '
        Me.Peao8b.BackColor = System.Drawing.Color.Transparent
        Me.Peao8b.ForeColor = System.Drawing.Color.Transparent
        Me.Peao8b.Image = CType(resources.GetObject("Peao8b.Image"), System.Drawing.Image)
        Me.Peao8b.Location = New System.Drawing.Point(567, 193)
        Me.Peao8b.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao8b.Name = "Peao8b"
        Me.Peao8b.Size = New System.Drawing.Size(73, 78)
        Me.Peao8b.TabIndex = 101
        Me.Peao8b.UseVisualStyleBackColor = False
        '
        'Peao3p
        '
        Me.Peao3p.BackColor = System.Drawing.Color.Transparent
        Me.Peao3p.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Peao3p.Image = CType(resources.GetObject("Peao3p.Image"), System.Drawing.Image)
        Me.Peao3p.Location = New System.Drawing.Point(167, 94)
        Me.Peao3p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao3p.Name = "Peao3p"
        Me.Peao3p.Size = New System.Drawing.Size(75, 78)
        Me.Peao3p.TabIndex = 100
        Me.Peao3p.UseVisualStyleBackColor = False
        '
        'Peao4p
        '
        Me.Peao4p.BackColor = System.Drawing.Color.Transparent
        Me.Peao4p.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Peao4p.Image = CType(resources.GetObject("Peao4p.Image"), System.Drawing.Image)
        Me.Peao4p.Location = New System.Drawing.Point(247, 94)
        Me.Peao4p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao4p.Name = "Peao4p"
        Me.Peao4p.Size = New System.Drawing.Size(75, 78)
        Me.Peao4p.TabIndex = 99
        Me.Peao4p.UseVisualStyleBackColor = False
        '
        'Peao5p
        '
        Me.Peao5p.BackColor = System.Drawing.Color.Transparent
        Me.Peao5p.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Peao5p.Image = CType(resources.GetObject("Peao5p.Image"), System.Drawing.Image)
        Me.Peao5p.Location = New System.Drawing.Point(326, 94)
        Me.Peao5p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao5p.Name = "Peao5p"
        Me.Peao5p.Size = New System.Drawing.Size(75, 78)
        Me.Peao5p.TabIndex = 98
        Me.Peao5p.UseVisualStyleBackColor = False
        '
        'Peao6p
        '
        Me.Peao6p.BackColor = System.Drawing.Color.Transparent
        Me.Peao6p.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Peao6p.Image = CType(resources.GetObject("Peao6p.Image"), System.Drawing.Image)
        Me.Peao6p.Location = New System.Drawing.Point(406, 94)
        Me.Peao6p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao6p.Name = "Peao6p"
        Me.Peao6p.Size = New System.Drawing.Size(75, 78)
        Me.Peao6p.TabIndex = 97
        Me.Peao6p.UseVisualStyleBackColor = False
        '
        'Peao7p
        '
        Me.Peao7p.BackColor = System.Drawing.Color.Transparent
        Me.Peao7p.ForeColor = System.Drawing.Color.Transparent
        Me.Peao7p.Image = CType(resources.GetObject("Peao7p.Image"), System.Drawing.Image)
        Me.Peao7p.Location = New System.Drawing.Point(485, 94)
        Me.Peao7p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao7p.Name = "Peao7p"
        Me.Peao7p.Size = New System.Drawing.Size(75, 78)
        Me.Peao7p.TabIndex = 96
        Me.Peao7p.UseVisualStyleBackColor = False
        '
        'Peao8p
        '
        Me.Peao8p.BackColor = System.Drawing.Color.Transparent
        Me.Peao8p.ForeColor = System.Drawing.Color.Transparent
        Me.Peao8p.Image = CType(resources.GetObject("Peao8p.Image"), System.Drawing.Image)
        Me.Peao8p.Location = New System.Drawing.Point(565, 94)
        Me.Peao8p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao8p.Name = "Peao8p"
        Me.Peao8p.Size = New System.Drawing.Size(75, 78)
        Me.Peao8p.TabIndex = 95
        Me.Peao8p.UseVisualStyleBackColor = False
        '
        'Peao2p
        '
        Me.Peao2p.BackColor = System.Drawing.Color.Transparent
        Me.Peao2p.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Peao2p.Image = CType(resources.GetObject("Peao2p.Image"), System.Drawing.Image)
        Me.Peao2p.Location = New System.Drawing.Point(88, 94)
        Me.Peao2p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao2p.Name = "Peao2p"
        Me.Peao2p.Size = New System.Drawing.Size(75, 78)
        Me.Peao2p.TabIndex = 94
        Me.Peao2p.UseVisualStyleBackColor = False
        '
        'Peao1p
        '
        Me.Peao1p.BackColor = System.Drawing.Color.Transparent
        Me.Peao1p.Image = CType(resources.GetObject("Peao1p.Image"), System.Drawing.Image)
        Me.Peao1p.Location = New System.Drawing.Point(11, 94)
        Me.Peao1p.Margin = New System.Windows.Forms.Padding(2)
        Me.Peao1p.Name = "Peao1p"
        Me.Peao1p.Padding = New System.Windows.Forms.Padding(1)
        Me.Peao1p.Size = New System.Drawing.Size(72, 78)
        Me.Peao1p.TabIndex = 93
        Me.Peao1p.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_Pausa
        '
        Me.btn_Pausa.BackColor = System.Drawing.Color.Yellow
        Me.btn_Pausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pausa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Pausa.Location = New System.Drawing.Point(738, 617)
        Me.btn_Pausa.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Pausa.Name = "btn_Pausa"
        Me.btn_Pausa.Size = New System.Drawing.Size(126, 31)
        Me.btn_Pausa.TabIndex = 128
        Me.btn_Pausa.Text = "Pausa"
        Me.btn_Pausa.UseVisualStyleBackColor = False
        Me.btn_Pausa.Visible = False
        '
        'btn_Novo_Jogo
        '
        Me.btn_Novo_Jogo.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_Novo_Jogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Novo_Jogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Novo_Jogo.Location = New System.Drawing.Point(869, 652)
        Me.btn_Novo_Jogo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Novo_Jogo.Name = "btn_Novo_Jogo"
        Me.btn_Novo_Jogo.Size = New System.Drawing.Size(126, 31)
        Me.btn_Novo_Jogo.TabIndex = 127
        Me.btn_Novo_Jogo.Text = "Novo jogo"
        Me.btn_Novo_Jogo.UseVisualStyleBackColor = False
        Me.btn_Novo_Jogo.Visible = False
        '
        'btn_Limpar_Resultados
        '
        Me.btn_Limpar_Resultados.BackColor = System.Drawing.Color.Red
        Me.btn_Limpar_Resultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpar_Resultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Limpar_Resultados.Location = New System.Drawing.Point(999, 652)
        Me.btn_Limpar_Resultados.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Limpar_Resultados.Name = "btn_Limpar_Resultados"
        Me.btn_Limpar_Resultados.Size = New System.Drawing.Size(177, 31)
        Me.btn_Limpar_Resultados.TabIndex = 126
        Me.btn_Limpar_Resultados.Text = "Limpar Resultados"
        Me.btn_Limpar_Resultados.UseVisualStyleBackColor = False
        Me.btn_Limpar_Resultados.Visible = False
        '
        'btn_Partida
        '
        Me.btn_Partida.BackColor = System.Drawing.Color.Lime
        Me.btn_Partida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Partida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Partida.Location = New System.Drawing.Point(738, 652)
        Me.btn_Partida.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Partida.Name = "btn_Partida"
        Me.btn_Partida.Size = New System.Drawing.Size(126, 31)
        Me.btn_Partida.TabIndex = 125
        Me.btn_Partida.Text = "Iniciar"
        Me.btn_Partida.UseVisualStyleBackColor = False
        '
        'mostrar_jogadas
        '
        Me.mostrar_jogadas.AutoSize = True
        Me.mostrar_jogadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mostrar_jogadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_jogadas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.mostrar_jogadas.Location = New System.Drawing.Point(740, 580)
        Me.mostrar_jogadas.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_jogadas.Name = "mostrar_jogadas"
        Me.mostrar_jogadas.Size = New System.Drawing.Size(135, 22)
        Me.mostrar_jogadas.TabIndex = 129
        Me.mostrar_jogadas.Text = "Mostrar jogadas"
        Me.mostrar_jogadas.UseVisualStyleBackColor = False
        '
        'Torre2b
        '
        Me.Torre2b.BackColor = System.Drawing.Color.Transparent
        Me.Torre2b.Image = CType(resources.GetObject("Torre2b.Image"), System.Drawing.Image)
        Me.Torre2b.Location = New System.Drawing.Point(561, 276)
        Me.Torre2b.Margin = New System.Windows.Forms.Padding(2)
        Me.Torre2b.Name = "Torre2b"
        Me.Torre2b.Padding = New System.Windows.Forms.Padding(1)
        Me.Torre2b.Size = New System.Drawing.Size(72, 78)
        Me.Torre2b.TabIndex = 130
        Me.Torre2b.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1286, 720)
        Me.Controls.Add(Me.Torre2b)
        Me.Controls.Add(Me.mostrar_jogadas)
        Me.Controls.Add(Me.btn_Pausa)
        Me.Controls.Add(Me.btn_Novo_Jogo)
        Me.Controls.Add(Me.btn_Limpar_Resultados)
        Me.Controls.Add(Me.btn_Partida)
        Me.Controls.Add(Me.Cavalo1p)
        Me.Controls.Add(Me.Bispo1p)
        Me.Controls.Add(Me.Reip)
        Me.Controls.Add(Me.Rainhap)
        Me.Controls.Add(Me.Bispo2p)
        Me.Controls.Add(Me.Cavalo2p)
        Me.Controls.Add(Me.Cavalo1b)
        Me.Controls.Add(Me.Bispo1b)
        Me.Controls.Add(Me.Reib)
        Me.Controls.Add(Me.Rainhab)
        Me.Controls.Add(Me.Bispo2b)
        Me.Controls.Add(Me.Cavalo2b)
        Me.Controls.Add(Me.Torre1b)
        Me.Controls.Add(Me.Torre2p)
        Me.Controls.Add(Me.Torre1p)
        Me.Controls.Add(Me.Peao1b)
        Me.Controls.Add(Me.Peao2b)
        Me.Controls.Add(Me.Peao3b)
        Me.Controls.Add(Me.Peao4b)
        Me.Controls.Add(Me.Peao5b)
        Me.Controls.Add(Me.Peao6b)
        Me.Controls.Add(Me.Peao7b)
        Me.Controls.Add(Me.Peao8b)
        Me.Controls.Add(Me.Peao3p)
        Me.Controls.Add(Me.Peao4p)
        Me.Controls.Add(Me.Peao5p)
        Me.Controls.Add(Me.Peao6p)
        Me.Controls.Add(Me.Peao7p)
        Me.Controls.Add(Me.Peao8p)
        Me.Controls.Add(Me.Peao2p)
        Me.Controls.Add(Me.Peao1p)
        Me.Controls.Add(Me.lb_Tempo)
        Me.Controls.Add(Me.Iniciar_Pretas)
        Me.Controls.Add(Me.Iniciar_Brancas)
        Me.Controls.Add(Me.Pecas_Brancas)
        Me.Controls.Add(Me.Pecas_Pretas)
        Me.Controls.Add(Me.lb_Vitoriasb)
        Me.Controls.Add(Me.lb_Vitoriasp)
        Me.Controls.Add(Me.txt_Jogador2)
        Me.Controls.Add(Me.txt_Jogador1)
        Me.Controls.Add(Me.l_jogador_2)
        Me.Controls.Add(Me.l_jogador_1)
        Me.Controls.Add(Me.torre_branco_1)
        Me.Controls.Add(Me.torre_preto_1)
        Me.Controls.Add(Me.peao_branco_1)
        Me.Controls.Add(Me.peao_preto_1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Name = "Form1"
        Me.Text = "Xadrez"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_Tempo As Label
    Friend WithEvents Iniciar_Pretas As CheckBox
    Friend WithEvents Iniciar_Brancas As CheckBox
    Friend WithEvents Pecas_Brancas As Label
    Friend WithEvents Pecas_Pretas As Label
    Friend WithEvents lb_Vitoriasb As Label
    Friend WithEvents lb_Vitoriasp As Label
    Friend WithEvents txt_Jogador2 As TextBox
    Friend WithEvents txt_Jogador1 As TextBox
    Friend WithEvents l_jogador_2 As Label
    Friend WithEvents l_jogador_1 As Label
    Friend WithEvents torre_branco_1 As Button
    Friend WithEvents torre_preto_1 As Button
    Friend WithEvents peao_branco_1 As Button
    Friend WithEvents peao_preto_1 As Button
    Friend WithEvents Cavalo1p As Button
    Friend WithEvents Bispo1p As Button
    Friend WithEvents Reip As Button
    Friend WithEvents Rainhap As Button
    Friend WithEvents Bispo2p As Button
    Friend WithEvents Cavalo2p As Button
    Friend WithEvents Cavalo1b As Button
    Friend WithEvents Bispo1b As Button
    Friend WithEvents Reib As Button
    Friend WithEvents Rainhab As Button
    Friend WithEvents Bispo2b As Button
    Friend WithEvents Cavalo2b As Button
    Friend WithEvents Torre1b As Button
    Friend WithEvents Torre2p As Button
    Friend WithEvents Torre1p As Button
    Friend WithEvents Peao1b As Button
    Friend WithEvents Peao2b As Button
    Friend WithEvents Peao3b As Button
    Friend WithEvents Peao4b As Button
    Friend WithEvents Peao5b As Button
    Friend WithEvents Peao6b As Button
    Friend WithEvents Peao7b As Button
    Friend WithEvents Peao8b As Button
    Friend WithEvents Peao3p As Button
    Friend WithEvents Peao4p As Button
    Friend WithEvents Peao5p As Button
    Friend WithEvents Peao6p As Button
    Friend WithEvents Peao7p As Button
    Friend WithEvents Peao8p As Button
    Friend WithEvents Peao2p As Button
    Friend WithEvents Peao1p As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_Pausa As Button
    Friend WithEvents btn_Novo_Jogo As Button
    Friend WithEvents btn_Limpar_Resultados As Button
    Friend WithEvents btn_Partida As Button
    Friend WithEvents mostrar_jogadas As CheckBox
    Friend WithEvents Torre2b As Button
End Class
