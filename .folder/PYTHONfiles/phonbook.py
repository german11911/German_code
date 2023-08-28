def load_file(filename):
    phonebook = []
    try:
        with open(filename, 'r', encoding='UTF-8') as file:
            for contact in file:
                last_name, first_name, middle_name, phone_number = contact.split(',')
                phonebook.append({
                    'last_name': last_name,
                    'first_name': first_name,
                    'middle_name': middle_name,
                    'phone_number': phone_number.rstrip()
                })
            print('Данные успешно загружены \n')
    except FileNotFoundError:
        print('Файл не найден \n')
    return phonebook

def correct_contacts(phonebook, search_key):
    search_key=search_key.lower()
    for contact in phonebook:
        if (search_key in contact['last_name'].lower() or search_key in contact['first_name'].lower() or search_key in contact['phone_number'].lower()):
            print(f"введите корректные данные, пустой ввод - без изменений :")
            temp = input(f"{contact['last_name']}  : ")
            if(temp):
                contact['last_name'] = temp
            temp = input(f"{contact['first_name']}  : ")
            if(temp):
                contact['first_name'] = temp
            temp = input(f"{contact['middle_name']}  : ")
            if(temp):
                contact['middle_name'] = temp
            temp = input(f"{contact['phone_number']}  : ")
            if(temp):
                contact['phone_number'] = temp
  
def search_contacts(phonebook, search_key):
    results = []
    search_key=search_key.lower()
    for contact in phonebook:
        if (search_key in contact['last_name'].lower() or search_key in contact['first_name'].lower() or search_key in contact['phone_number'].lower()):
            results.append(contact)
    return results

def views_contacts(phonebook):
    for index, contact in enumerate(phonebook, start=1):
        print(f"{index}. {contact['last_name']}, {contact['first_name']}, {contact['middle_name']}, {contact['phone_number']}")
    print("")
def save_to_file(filename, phonebook):
    with open(filename, 'w', encoding='UTF-8') as file:
        for contact in phonebook:
            file.write(f"{contact['last_name']},{contact['first_name']},{contact['middle_name']},{contact['phone_number']}\n")
    print('Данные сохранены в файле \n')

def add_contact(phonebook, last_name, first_name, middle_name, phone_number):
    contact = {
        'last_name': last_name,
        'first_name': first_name,
        'middle_name': middle_name,
        'phone_number': phone_number
    }
    phonebook.append(contact)
    print('Контакт добавлен\n')

def remove_contacts(phonebook, search_key):
    search_key=search_key.lower()
    for contact in phonebook:
        if (search_key in contact['last_name'].lower() or search_key in contact['first_name'].lower() or search_key in contact['phone_number'].lower()):
            a = input(f"{contact} Этот контакт удалить ? да/нет y/n     ")
            if(a == 'y' or a== "да" or a== "yes" or a=="Yes" or a=="Да"):
                phonebook.remove(contact)
                print('Контакт удалён\n')

def main():
    phonebook = []
    filename = 'contacts.txt'

    while True:
        print("1. Добавить контакт")
        print("2. Сохранить файл")
        print("3. Вывести все контакты")
        print("4. Поиск по имени/фамилии")
        print("5. Загрузить из файла")
        print("6. Редактировать запись")
        print("7. Удавление контакта")
        print("8. Выйти")

        choice = input('Выберите действие: ')
        if choice == '1':
            last_name = input('Фамилия: ')
            first_name = input('Имя: ')
            middle_name = input('Отчество: ')
            phone_number = input('Номер телефона: ')
            add_contact(phonebook, last_name, first_name, middle_name, phone_number)
        elif choice == '2':
            save_to_file(filename, phonebook)
        elif choice == '3':
            views_contacts(phonebook)
        elif choice == '4':
            search_key = input("Введите имя, фамилию или телефон для поиска: ")
            results = search_contacts(phonebook, search_key)
            if (results):
                print('Найдены контакты: ')
                print(results)
            else:
                print('Контактов по вашему запросу нет!')
        elif choice == '5':
            phonebook = load_file(filename)
        elif choice == '6':
            search_key = input("Введите имя, фамилию или телефон для поиска: ")
            correct_contacts(phonebook, search_key) 
        elif choice == '7':
            search_key = input("Введите имя, фамилию или телефон для поиска: ")
            remove_contacts(phonebook, search_key) 
        elif choice == '8':
            break
        else:
            print('Некорректный выбор. Попробуйте снова')




if __name__ == "__main__":
    main()
