import pandas as pd

# Ваш исходный код
random.seed(42)  # для воспроизводимости случайных результатов
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})

# Создаем one-hot encoding
categories = pd.unique(data['whoAmI'])
one_hot = pd.DataFrame(0, columns=categories, index=data.index)
one_hot = one_hot.add(pd.get_dummies(data['whoAmI']))

# Объединяем исходный DataFrame с one-hot encoding
data_encoded = pd.concat([data, one_hot], axis=1)

# Выводим результат
data_encoded.head()