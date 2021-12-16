create view qianyg_学生总成绩视图(学号,姓名,专业,学期,总成绩)
as
  select  qianyg_学生成绩视图.学号,qianyg_学生成绩视图.姓名,qianyg_学生成绩视图.专业,
          qianyg_学生成绩视图.学期,SUM(成绩)
  from qianyg_学生成绩视图
  group by 学号,姓名,专业,学期
