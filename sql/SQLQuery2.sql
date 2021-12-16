create table qianyg_学生  (
   qyg_学号  char(12)  PRIMARY  KEY,
   qyg_姓名  char(20)  NOT  NULL,
   qyg_性别  char(2)  check  (qyg_性别  =  '男' or qyg_性别  =  '女') NOT NULL,
   qyg_年龄  int  check(qyg_年龄  > 0 and qyg_年龄  < 200) NOT  NULL,
   qyg_生源所在地  char(20)  NOT  NULL,
   qyg_已修学分  float,
   qyg_班级编号  char(6),
   constraint  FK_班级_学生  foreign  key  (qyg_班级编号) references qianyg_班级
   )
