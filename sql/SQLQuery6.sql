create table qianyg_学生成绩  (
   qyg_学号  char(12),
   qyg_课程编号  char(20),
   qyg_教师编号  char(20),
   qyg_学期  char(20)   NOT  NULL,
   qyg_成绩  float,   
   constraint  PK_学生成绩  primary  key  (qyg_学号,qyg_课程编号,qyg_学期),
   constraint  FK_学号_学生成绩  foreign  key  (qyg_学号) references qianyg_学生,
   constraint  FK_课程编号_学生成绩  foreign  key  (qyg_课程编号) references qianyg_课程,
   constraint  FK_教师编号_学生成绩  foreign  key  (qyg_教师编号) references qianyg_教师
   )
