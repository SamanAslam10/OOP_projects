from service import Service
from model import Model
class UI:

    @staticmethod
    def menu():
        print("****************")
        print("******Shop******")
        print("****************")
        print("1. View Products")
        print("2. Add products")
        option = int(input("Choose option :"))
        return option
    
    def printProducts(ProductsList):
        for p in ProductsList:
            print(p.Name , p.Price , p.Quantity )
    
    def AddProducts():
        name = input("Name : ")
        price = input("Price : ")
        quantity = input("Quantity : ")
        m = Model(name , price , quantity)
        Service.Save(m)

    def Driver():
        option = UI.menu()
            