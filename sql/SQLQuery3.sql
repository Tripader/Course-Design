create table qianyg_教师  (
   qyg_教师编号  char(20)  PRIMARY  KEY,
   qyg_姓名  char(20)  NOT  NULL,
   qyg_性别  char(2)  check  (qyg_性别  =  '男' or qyg_性别  =  '女') NOT NULL,
   qyg_年龄  int  check(qyg_年龄  > 0 and qyg_年龄  < 200) NOT  NULL,
   qyg_职称  char(20)  NOT  NULL,
   qyg_联系电话  char(6) NOT  NULL
   )
