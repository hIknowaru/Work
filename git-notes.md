История работы с Git



1\. Создан локальный репозиторий.

2\. Создан первый коммит Initial commit.

3\. Добавлен файл README.md.

4\. Создана ветка feature/git-basics.

5\. Изменён README.md в отдельной ветке.

6\. Выполнено слияние feature/git-basics с master.

7\. Создана ветка feature/conflict-demo.

8\. Изменён README.md в обеих ветках.

9\. Возник конфликт слияния.

10\. Конфликт разрешён вручную.

11\. Создан merge-коммит Resolve merge conflict in README.



## Git log after rebase

7a65b4a docs: add rebase demo file
23035a6 Merge pull request #1 from hIknowaru/feature/task-35
8ece8bb docs: describe git workflow
565d51b docs: add contribution guidelines
fb84a73 chore: add gitignore and editorconfig
4d458cc Add C# practice project files
432d73a Add Git history notes
c587236 Resolve merge conflict in README
163eedf Change README in main branch
6c9792e Change README in feature branch
90a0aa6 Update README in feature branch
91d3636 Add project documentation
5a5fb2b Initial commit: add practice project



\## Задание №47. Git Rebase -i (Squash)



\### История до объединения



9a9246e (HEAD -> feature/squash-demo) docs: add fourth demo note

3f345fb docs: add third demo note

02144e8 docs: add second demo note

beeef22 docs: add squash demo file



\### История после объединения



6c31882 (HEAD -> feature/squash-demo) docs: combine four squash demo commits

70c39a8 (feature/rebase-demo) docs: save git log after rebase

7a65b4a docs: add rebase demo file

23035a6 (origin/main, origin/HEAD, main) Merge pull request #1 from hIknowaru/feature/task-35



\### Результат



Четыре коммита успешно объединены в один с помощью git rebase -i HEAD\~4 и команды squash.

## Задание №48. Git: аннотированные теги



\### Создание тега

Создан аннотированный тег v1.0.0 с сообщением "Release v1.0.0".



\### Проверка

Команда git tag показала:

v1.0.0



Команда git show v1.0.0 подтвердила:

\- Тег: v1.0.0

\- Сообщение: Release v1.0.0

\- Тег указывает на стабильный коммит ветки main.



\### Отправка на GitHub

Выполнена команда git push origin v1.0.0.



Проверка git ls-remote --tags origin v1.0.0 подтвердила наличие тега в удалённом репозитории.## Задание №48. Git: аннотированные теги



\### Создание тега

Создан аннотированный тег v1.0.0 с сообщением "Release v1.0.0".



\### Проверка

Команда git tag показала:

v1.0.0



Команда git show v1.0.0 подтвердила:

\- Тег: v1.0.0

\- Сообщение: Release v1.0.0

\- Тег указывает на стабильный коммит ветки main.



\### Отправка на GitHub

Выполнена команда git push origin v1.0.0.



Проверка git ls-remote --tags origin v1.0.0 подтвердила наличие тега в удалённом репозитории.

## Задание №49. Восстановление коммита через reflog



\### 1. Создание тестового коммита

Создан файл reflog-demo.txt.



Команда:

git commit -m "test: add reflog recovery demo"



\### 2. Удаление коммита

Выполнена команда:

git reset --hard HEAD\~1



Коммит временно исчез из истории текущей ветки.



\### 3. Поиск коммита через reflog

Выполнена команда:

git reflog



Коммит найден в записи HEAD@{1}.



\### 4. Восстановление коммита



Для восстановления использована команда:



git reset --hard <хеш коммита>



Мой хеш: 82cceb3

Хеш Дианы: 8331ec9



\### 5. Проверка

Выполнены команды:

git log --oneline -1

git status

git reflog



Восстановление прошло успешно. Тестовый коммит снова находится в HEAD, файл reflog-demo.txt восстановлен.

Задание 50. Поиск ошибки с помощью git bisect

Цель: найти коммит, в котором появилась ошибка, используя команду git bisect.

Выполнение:

Создана отдельная ветка feature/bisect-demo.

Создан файл BisectDemo.cs с рабочей функцией AddTwo, которая прибавляет 2 к числу.

Созданы промежуточные коммиты.

В коммите c4c65af намеренно допущена ошибка: number + 2 заменено на number - 2.

Созданы последующие контрольные коммиты.

Запущен поиск:

git bisect start

git bisect bad

git bisect good 5bb17fe

Проверяемые версии отмечались командами git bisect good и git bisect bad.

После поиска Git определил первый плохой коммит.

Результат:

Найден первый плохой коммит: c4c65af — bug: break AddTwo calculation.

Git вывел сообщение:

c4c65afa6979556e5788d91b08fa640a272cfac9 is the first 'bad' commit.

Журнал поиска: git bisect log.

Завершение: выполнена команда git bisect reset, возвращающая HEAD к последнему коммиту исходной ветки поиска.

Вывод: с помощью бинарного поиска Git удалось определить коммит, в котором появилась ошибка, не проверяя вручную каждый коммит.

