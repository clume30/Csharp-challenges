#CLI to-do list manager
print("welcome to my CLI manager")
my_task = ["eat palmcake", "buy doughnuts", "drinking water", "playing about", "exit"]
task = ""
tasks = ""
i = 0
i = int(input("1. add tasks\n2. view tasks\n3. delete tasks\nWhat do you want to do today: "))
#add tasks
if i == 1:
    while task != "exit":
        task = input("Enter your task: ").lower()
        my_task.append(task)
    my_task.pop() #removes the last value 'exit' from my_task 
    print("your tasks are:", my_task)
#view tasks
elif i == 2:
    print("Your list contains:", my_task)
#delete tasks
elif i == 3:
    while tasks != "exit":
        print("Your tasks are:", my_task)
        tasks = input("Enter the task do you want to delete?: ").lower()
        my_task.remove(tasks)
        
    print("Your list contains:", my_task)

       
    