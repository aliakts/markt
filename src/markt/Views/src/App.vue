<template>
  <article class="recipe">
    <h2>Chicken Vindaloo</h2>
    <p>
      “Vindaloo” is a popular Indian <a href="">curry dish</a> that calls for meat to be marinated in a highly flavorful spicy mixture with vinegar, then quickly cooked up when you’re ready to eat.
    </p>
    <p>
      While this dish has a long list of spices, most are quite common in the average spice rack. If you find you're missing one, it's not a deal breaker. You will still have a lovely, fragrant curry.
    </p>
    <aside>
      <p>
        Quick warning: <strong>this recipe is <em>spicy</em></strong>. <a href="">Click here</a> for an alternative recipe with less heat.
      </p>
    </aside>
  </article>
  <br>
  <!-- color -->
  <div class="first box"></div>
  <div class="second box"></div>
  <div class="third box"></div>
  <div class="fourth box"></div>
  <p>
    This is a paragraph with a
    <em>highlighted section</em>.
  </p>
</template>

<style>
article a {
  color: deeppink;
  text-decoration: none;
}

article a:hover {
  text-decoration: underline;
}

aside a {
  color: black;
  text-decoration: underline;
}

aside a:hover {
  text-decoration: none;
}

#body {
  padding: 16px 32px;
}

h2 {
  font-size: 2rem;
  margin-bottom: 1rem;
}

p {
  margin-bottom: 24px;
}

/* We'll learn about this later on! */
aside p:last-of-type {
  margin-bottom: 0;
}

aside {
  background: peachpuff;
  border: 2px solid;
  padding: 16px;
}

/* color */
.box {
  width: 50px;
  height: 50px;
}

.first.box {
  background-color: hsl(340deg 100% 50% / 1);
}
.second.box {
  background-color: hsl(340deg 100% 50% / 0.75);
}
.third.box {
  background-color: hsl(340deg 100% 50% / 0.5);
}
.fourth.box {
  background-color: hsl(340deg 100% 50% / 0.25);
}
em {
  background-color: hsl(50deg 100% 50%);
}
</style>
