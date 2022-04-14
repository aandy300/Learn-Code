import { createRouter, createWebHashHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  },
  {
    path: '/newpage', // 網頁自訂用的網址名稱
    name: '新增頁面', // 動態屬性加入用的名稱 - :to="{ name: '新增頁面' }"
    component: () => import('../views/NewPage.vue'),
    children: [
      {
        path: 'a', // 子路由可以直接打名稱不需要 /
        component: () => import('../views/ConponentA.vue')
      },
      {
        path: 'b',
        component: () => import('../views/ConponentB.vue')
      },
      {
        path: 'dynamicRouter', // :之後是可自訂義名稱、動態路由動態的部分
        component: () => import('../views/DynamicRouter.vue')
      },
      {
        path: 'nameview',
        // name: '命名路由', // 非必要?
        component: () => import('../views/NamedView.vue'),
        children: [
          {
            path: 'c2a',
            components: {
              left: () => import('../views/ConponentC.vue'),
              right: () => import('../views/ConponentA.vue')
            }
          },
          {
            path: 'b2c',
            components: {
              left: () => import('../views/ConponentB.vue'),
              right: () => import('../views/ConponentC.vue')
            }
          }
        ]
      }
    ]
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
