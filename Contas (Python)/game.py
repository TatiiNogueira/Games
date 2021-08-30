#Módulos
#Importação de Ficheiros
from models.calcular import Calcular

#Função irá retornar None
def main() -> None:
    pontos: int = 0
    jogar(pontos)

#Função jogar irá retornar None
def jogar(pontos: int) -> None:
    dificuldade: int = int(input('Informe o nível de dificuldade (1,2,3,4): '))

    #Chamar a class Calcular
    calc : Calcular = Calcular(dificuldade)

    print('Informe o resultado para a seguinte operação')

    calc.mostrar_operacao()

    resultado: int = int(input('Resultado: '))

    #Se o resoltado for correto ganhamos 1 ponto
    if calc.verificar_resultado(resultado):
        pontos += 1
        print('Ganhou 1 ponto')

    continuar: int = int(input('Desejas continuar o jogo? (1 - sim, 0 - não): '))

    if continuar:
        jogar(pontos)
    else:
        print('Jogo terminado')
        print(f'Pontuação obtida -----> {pontos} ponto(s)')
        print('Até à próxima \U0001F603')

#Colocar o programa a correr
if __name__ == '__main__':
    main()