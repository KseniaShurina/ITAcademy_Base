﻿1. Спроектировать тип Car, у которого есть поле int Age. Создать консольное приложение, которое будет:
	a. Создавать List машинок и добавлять в него 100000000 элементов. Логично, что вы будете делать это в цикле
		так, чтобы Age был различным у объектов.
	б. обычным foreach пройтись по листу и изменить Age на (343 * 34 * 2 * 77)/567
	в. сделать это же в for цикле
	г. сделать это же в for Parallel.ForEach
	д. сделать это же в for Parallel.For
	е. использовать Stopwatch, чтобы понять, какой цикл самый быстрый. Вывести результаты подсчетов на экран
При тестировании используйте Release mode и Ctrl+F5, чтобы полностью использовать все оптимизации.
	
2. Кто не сделал на занятии, или хочет повторить:
	Создать три файла. В двух должен быть какой-то текст, последний пустой.
	Прочитать содержимое первых двух файлов в различных потоках и записать результаты чтения в третий файл так, чтобы
	операции записи не мешали друг другу.