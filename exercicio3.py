import json

#Obtendo os valores do arquivo json
with open('dados.json',  'r') as file:
    data = json.load(file)

faturamentoDiario = data['faturamentoDiario']
valores = []


for dayData in faturamentoDiario:
        valores.append(dayData['valor'])

# Trabalhando os valores obtidos

diferentesDeZero = []

for valor in valores:
    if valor > 0:
        diferentesDeZero.append(valor)


menorValor = min(diferentesDeZero)
maiorValor = max(diferentesDeZero)
media = sum(diferentesDeZero) / len(diferentesDeZero)
diasAcimadaMedia = 0

for valor in valores:
    if valor > media:
        diasAcimadaMedia += 1

print(f"Menor valor de faturamento ocorrido em um dia do mês: {menorValor}")
print(f"Maior valor de faturamento ocorrido em um dia do mês: {maiorValor}")
print(f"Media mensal: {media:.2f}")
print(f"Numero de dias acima da media: {diasAcimadaMedia}")



