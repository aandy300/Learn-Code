<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
	<style type="text/css"> /*css*/
		table, th, td{
			border: 1px solid black;
			border-collapse: collapse; /*外框限取消*/
		}
		
	</style>
</head>
<body>

	<header>
			<h1>my zoo</h1>
	</header>

	<nav> <!-- 導覽列 -->
		<ul>
			<li>home</li>
			<li>about</li>
			<li>Contact</li>
		</ul>
	</nav>

	<section> <!-- 文章內容一部分 -->
		<img src="MAMP-PRO-Logo.png" alt="om" width="100%">
	</section>
	
	<section>
		<h2>my video</h2>
		<br>
		<video src="1.mp4" type="video/mp4" controls="" width="600"></video>
	</section>

	<article> <!-- 文章主體 -->
		<h3>title1</h3>
		<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis quas voluptatibus tempora culpa qui porro numquam quasi neque. Magni aspernatur dolores, aut aliquid dolore nobis repudiandae voluptatem rerum est accusantium.</p>
	</article>

	<br>
	<hr>
	<br>

	<article>
		<h3>title2</h3>
		<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis quas voluptatibus tempora culpa qui porro numquam quasi neque. Magni aspernatur dolores, aut aliquid dolore nobis repudiandae voluptatem rerum est accusantium.</p>
	</article>

	<br>
	<hr>
	<br>

	<section>
			<table style="width: 100%"> <!-- 欄位 -->
				<caption>my animeals</caption>
				<tr>
					<th>animals</th> <!-- 大欄位 -->
					<th>amount</th>
				</tr>
				<tr>
					<td>LION</td> <!-- 小欄位(數值) -->
					<td>36</td>
				</tr>
				<tr>
					<td>ele</td>
					<td>33</td>
				</tr>
			</table>
	</section>

	<br>
	<hr>
	<br>

	<footer>
		<form action="">
			Email address: <br>
			<input type="eil" name="email" value="Email"> <br>
			Message:	<br>
			<textarea rows="4" cols="50"></textarea> <br>
		</form>
	</footer>
	
	<p>&copy; 2018 mark icon</p>

</body>
</html>