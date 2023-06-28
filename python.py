import re
def check_password(password):
    if len(password) < 8 or len(password) > 20:
        return False
    if not re.search(r'\d', password):
        return False
    if not re.search(r'[A-Z]', password):
        return False
    if not re.search(r'[a-z]', password):
        return False
    if not re.search(r'[W_]', password):
        return False
    return True
while True:
    password = input("Введите пароль:")
    if check_password(password):
        print("Пароль верный")
        break
    else:
        print("Пароль неверный, повторите еще раз")
