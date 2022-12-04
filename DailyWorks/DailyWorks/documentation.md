# Proqramın mahiyyəti
Bu proqram bir tələbənin gündəlik işlərini planlaşdırılması üçün 
yaradılmışdır.
# Proqramın funksionallığı
### 1. Tasklarımızı görmək(tamamlanmış, tamamlanmamış, yaxud hamısı)
### 2. Yeni task əlavə etmək
### 3. Müəyyən task haqqında məlumatları yeniləmək
### 4. Task silmək

# Proqramın iri  hissələri

## 1.Models
Bu hissədə proqramdakı obyektlərin şablonu müəyyən edilir.
### TaskSchema obyektinin şablonu
#### Properties
- TaskId- Task-ı digərlərindən fərqləndirən unikal nömrə
- TaskName - Taskın adı
- TaskImportance - Taskın vaciblik dərəcəsini göstərir(çox,orta,az)
- TaskTime - Taska ayıra biləcəyimiz zamanı saat ölçüsü ilə göstərir.
- TaskStatus - Taskın statusunu göstərir(ya tamamlanıb, ya da tamamlanmayıb)
#### Methods
Task obyektinin metodları yoxdur(hələki, bəlkə  ağlıma gəldi sonra)

## 2.Controllers
Bu hissədə proqramdakı obyektləri idarə edən controllerlərin şablonu müəyyən edilir.
### TaskController-in şablonu
#### Properties
TaskContoller-in property-si yoxdur(hələki, bəlkə sonra ağlıma gəldi)
#### Methods
- CreateTask- Task-ı yaradır və pudatabase-ə əlavə edir.
- ReadTasks- Taskları ekrana çıxartmaq  
- DeleteTask - Taskı siyahıdan silir.
- UpdateTask - Taskın statusunu yeniləyir,və tamamlanmışlar siyahısına köçürür.

## 3.Database
Bu hissədə proqramdakı dataların saxlanması təmin edilir edilir.
### Database obyektinin şablonu
#### Properties
- CompletedTasks - Tamamlanmış taskların olduğu siyahı
- IncompletedTasks - Tamamlanmamış taskların olduğu siyahı
#### Methods
Database obyektinin metodları yoxdur(hələki, bəlkə  ağlıma gəldi sonra)
