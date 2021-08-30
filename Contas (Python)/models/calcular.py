#Modulos
from random import randint

class Calcular:
    #Construtor que vai receber a dificuldade do tipo inteiro e o
    #retorno desse metodo será None
    #NOTA:#_gerar_valor é uma função privada,
          #vamos gerar uma propriedade por isso a função não tem ()
    def __init__(self: object, dificuldade: int) -> None:
        #Dificuldade recebida será do tipo inteira
        self.__dificuldade: int = dificuldade
        #Valor1 será do tipo float
        self.__valor1: float = self._gerar_valor
        #Valor2 será do tipo float
        self.__valor2: float = self._gerar_valor
        #Operação recebida será do tipo inteiro
        #1 = Somar      2 = Subtrair       3 = Multiplicar
        self.__operacao: int = randint(1,3)
        #Resultado será do tipo float
        self.__resultado: float = self._gerar_resultados

    #Propriedades
    #A seguir da seta -> é o tipo de retorno
    @property
    def dificuldade(self: object) -> int:
        return self.__dificuldade

    @property
    def valor1(self: object) -> int:
        return self.__valor1

    @property
    def valor2(self: object) -> int:
        return self.__valor2

    @property
    def operacao(self: object) -> int:
        return self.__operacao

    @property
    def resultado(self: object) -> int:
        return self.__resultado

    def __str__(self: object) -> str:
        #op é uma variável
        op: str = ''
        #Indicaçao da peração
        if self.operacao == 1:
            op = 'Somar'
        elif self.operacao == 2:
            op = 'Diminuir'
        elif self.operacao == 3:
            op = 'Multiplicar'
        else:
            op = 'Operação desconhecida'
        #Retorno da string(Frase)
        return f'Valor 1: {self.valor1}\nValor 2: {self.valor2}\nDificuldade: {self.dificuldade}\nOperação: {op}'

    @property
    def _gerar_valor(self: object) -> int:
        if self.dificuldade == 1:
            return randint(0,10)
        elif self.dificuldade == 2:
            return randint(0,100)
        elif self.dificuldade == 3:
            return randint(0,1000)
        elif self.dificuldade == 4:
            return randint(0,10000)
        else:
            return randint(0,100000)

    @property
    def _gerar_resultados(self: object) -> int:
        #Somar
        if self.operacao == 1:
            return self.valor1 + self.valor2
        #Subtração
        elif self.operacao == 2:
            return self.valor1 - self.valor2
        #Multiplicação
        else:
            return self.valor1 * self.valor2

    @property
    def _op_simbolo(self: object) -> str:
        if self.operacao == 1:
            return '+'
        elif self.operacao == 2:
            return '-'
        else:
            return '*'

    #Imprime se a resposta está correta ou incorreta
    def verificar_resultado(self: object, resposta: int) -> bool:
        certo: bool = False
        if self.resultado == resposta:
            print('\U0001F308 Resposta Correta \U0001F308')
            certo = True
        else:
            print('\U0001F645 Resposta Incorreta \U0001F645')
        #Retorna a conta com o resultado à frente
        print(f'{self.valor1} {self._op_simbolo} {self.valor2} = {self.resultado}')
        return certo

    #Conta
    def mostrar_operacao(self: object) -> None:
        print(f'{self.valor1} {self._op_simbolo} {self.valor2}')