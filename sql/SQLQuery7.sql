create table qianyg_ѧ������  (
   qyg_ѧ��  CHAR(12)  PRIMARY  KEY,
   qyg_����  CHAR(20)  NOT  NULL,
   constraint  FK_ѧ��_ѧ������  foreign  key  (qyg_ѧ��) references qianyg_ѧ��    
   )
