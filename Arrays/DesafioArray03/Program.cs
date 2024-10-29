for mes int range(1, 12):


  temperatura = float(input(f"Digite a temperatura média do mês {mes}: "))
  temperaturas.append(temperatura)

# Encontra a maior e a menor temperatura
maior_temperatura = max(temperaturas)
menor_temperatura = min(temperaturas)

# Imprime os resultados
print(f"A maior temperatura do ano foi: {maior_temperatura:.1f}°C")
print(f"A menor temperatura do ano foi: {menor_temperatura:.1f}°C")