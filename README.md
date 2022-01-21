# Atividade1_WPF

CRUD baseado na trilogia de jogos da Bioware, chamada Mass Effect. Não abordo todos os elementos possíveis e nem raças, é pra servir como um CRUD básico mesmo.

#Pontos à se destacar:
Criei uma classe chamada EnumBindingSource herdando de MarkupExtension para conseguir fazer uso dos meus Enums nos Combobox que inseri nas janelas de inserção e edição.
Não sei se era o melhor método para isso, mas foi o mais curto dentro das pesquisas que fiz.

#Dúvidas:
Tô com bastante dificuldade para desabilitar o botão de remover. Fiz várias pesquisas e testei algumas coisas qque eu achei que seriam mais simples. Nenhuma delas 
funciona. Tentei usar minha própria lógica e também não funciona efetivamente. Muito provavelmente é alguma coisa besta que está faltando. No código atual fiz um método 
separado para fazer o controle do desligamento do botão. Em teermos de código parece correto, porém ele não age como deveria. Inclusive exportei um método que lê quando a 
janela está ativa, nele eu insiro o método de alteração do botão. Ele inicia bem, desabilitado, mas não atualiza depois que eu insiro um elemento na lista. Não sei se estou 
abordando da maneira incorreta, mas imagino que a solução seja relativamente simples, por conta do RelayCommand, só não descobri como ainda.

Na parte de edição a janela está pronta, mas não consegui fazer nada muito à fundo para que funcionasse da forma correta, visto que tava tentando dar um foco no botão remover e
deixar a edição pro final de semana.
