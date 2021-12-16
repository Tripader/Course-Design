create table qianyg_选课情况  (
   qyg_课程编号  char(20),
   qyg_班级编号  char(6),
   qyg_教师编号  char(20),
   qyg_学期 char(20),
   constraint  PK_选课情况  primary  key  (qyg_课程编号,qyg_班级编号,qyg_教师编号),
   constraint  FK_课程_选课  foreign  key  (qyg_课程编号) references qianyg_课程,
   constraint  FK_班级_选课  foreign  key  (qyg_班级编号) references qianyg_班级,
   constraint  FK_教师_选课  foreign  key  (qyg_教师编号) references qianyg_教师
   )
