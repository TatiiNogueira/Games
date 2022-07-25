#Link do Video -> https://www.youtube.com/watch?v=cJJTnI22IF8
""" 
NOTAS:
O programa converte a letra que o utilizador introduziu por letra maiúscula (Foi definido no código)
"""

#Módulos
import random
import string
#Importar Ficheiros
from Palavras import *
from Visual_Forca import *


def get_valid_word(words):
    """
    Obtem uma palavra aleatória da lista de palavras

    Args:
        words (list): Lista de palavras

    Returns:
        word (str): Palavra escolhida
    """
    #Escolhe uma palavra da lista de palavras aleatóriamente
    word = random.choice(words)
    #Procura por uma palavra que não tenha espaços nem traços
    while '-' in word or ' ' in word:
        word = random.choice(words)

    return word


def hangman():
    """
    Função Principal
    """
    word = get_valid_word(words)
    #Salva que letras existem na palavra
    word_letters = set(word)
    #Alfabeto com carateres maiúsculos
    alphabet = set(string.ascii_uppercase)
    #Letras que o utilizador acertou
    used_letters = set()
    #Vidas
    lives = 8

    #Enquanto a plavra tiver um comprimento superior a 0 carateres e o utilizador tiver mais do que 0 vidas
    while len(word_letters) > 0 and lives > 0:
        #".join" junta as letras usadas e converte as mesmas numa string
        if len(' '.join(used_letters)) == 0:
            print('Tens 8 vidas')
        else:
            print(f'Restam te {lives} vidas e as letras que já foram usadas são: ', ' '.join(used_letters))
        #As letras que foram adivinhadas aparecem, as letras que ainda não foram adivinhadas irão aparecer "-"
        word_list = [letter if letter in used_letters else '-' for letter in word]
        print(lives_visual_dict[lives])
        #Mostra como está a palavra
        print('Palavra atualmente: ', ' '.join(word_list))
        #Pergunta ao Utilizador, o ".upper()" coloca a letra em maiúscula
        user_letter = input('Adivinha a letra: ').upper()
        #Se for um carater válido no alfabeto que ainda não foi usado
        if user_letter in alphabet - used_letters:
            #Adiciona a letra ao conjunto de letras
            used_letters.add(user_letter)
            #Se a letra estiver na palavra que é para adivinhar
            if user_letter in word_letters:
                #Removemos a letra das letras da plavra para adivinhar
                word_letters.remove(user_letter)
                print('')

            else:
                #Se o utlizador errar a letra perde uma vida
                lives = lives - 1
                print('\nA palavra não contem a letra ', user_letter)

        elif user_letter in used_letters:
            print(f'\nA letra {user_letter} já foi utilizada')

        else:
            print('\nLetra inválida, não são aceites números nem carateres especiais, apenas letras')

    # gets here when len(word_letters) == 0 OR when lives == 0
    if lives == 0:
        print(lives_visual_dict[lives])
        print('Perdes te !! A palavra era', word, '\U0001F4A3')
    elif lives == 8:
        print(f'PARABÉNS!!!! Acertas te sem errar nenhuma vez, a palavra era {word} \U0001F381!!')
    else:
        print(f'PARABÉNS!!!! Acertas te a palavra com {lives} vidas, a palavra era {word} \U0001F603!!')

#Iniciar o programa
if __name__ == '__main__':
    print("Adivinha qual é o alimento, molho ou tempero")
    print("Nenhuma palavra contém carateres especiais")
    print("VAMOS LÁ!!!\n\n")
    hangman()