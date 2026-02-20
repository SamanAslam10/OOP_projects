from repo import Repo
class Service:

    def Save(model):
        Repo.Create(model)
    
    def Load():
        list = []
        list = Repo.Get()
        return list