import os.path
from model import Model
class Repo:

    productsList = []
    def Create(m):
        if(os.path.exists("data.txt")):
            f = open("data.txt", 'a')
            f.write(m.name , m.price , m.quantity)
            f.close()
        else:
            print("File doesn't exist!")

    def Get():
        if(os.path.exists("data.txt")):
            f = open("data.txt",'r')
            lines = f.read()
            f.close()
            for line in lines:
                name , product , quantity = Repo.ParseData(line)
                m = Model(name , product , quantity)
                Repo.AddintoList(m)
            
            return Repo.productsList
        else:
            print("File doesn't exist!")

    def ParseData(line):
        line = line.split(',')
        return line[0],line[1],line[2]

    def AddintoList(product):
        Repo.productsList.append(product)
        