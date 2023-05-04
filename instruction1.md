# **Инструкция по работе с программой git**

#При первом запуске программы Git провести инициализацию пользователя командами
**git config --global user.name "<моё_имя>"**
#Установим имя для вашего пользователя
#Теперь установим email. 
**git config --global user.email "<german@serpantin.ru>"**

#Инициализация/создание репозитория
**git init**
#команда запускается из папки, которую надо селать репозиторием

#Команда **git status** показывает текущее состояние нашего репозитория. Выводится в том числе список файлов. красным цветом изменённые файлы, не отслеживаемые программой git. Зелёным - отслеживаемые.

#Для добавления файлов под контроль git используется команда **git add <имя файла>**

#создание точки фиксации изменений файлов. Команда **git commit -m "comments"**

#создание новой ветви версий файлов
команда **git branch <имя новой ветви>**
команда **git branch** выводит список ветвей
**git branch -d <branch.name>** удаление ветки

#переключение между ветвями команда **git checkout <branch.name>**

#слияние ветвей **git marge <branch.name>** слияние ветвей. запускается из ветви **master** и указывается имя ветви, которую надо слить с основной

#
git log команда выводит журнал выполненых коммитов
# вроде основные все команды