create table qianyg_教授课程(
   qyg_课程编号  char(20),
   qyg_教师编号  char(20),
   constraint  FK_课程_教师  foreign  key  (qyg_课程编号) references qianyg_课程,
   constraint  FK_教师_课程  foreign  key  (qyg_教师编号) references qianyg_教师
)