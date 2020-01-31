import React from 'react';
import Main from './components/main/Main';
import { default as AdminCategories } from './components/admin/categories/Categories';
import Categories from './components/categories/Categories';
import Store from './components/store/Store';
import Cart from './components/cart/Cart';
import Checkout from './components/checkout/Checkout';
import { Route, Switch } from 'react-router-dom';
import CategoryDetails from './components/categories/CategoryDetails';

/*
 * When you add route don't forget to add breadcrumb for it in Breadcrumb.js
 */
export const routes = [
  {
    path: '/',
    name: 'Main',
    component: Main,
    exact: true
  },
  {
    path: "/admin/categories",
    name: "admin/categories",
    component: AdminCategories
  },
  {
    path: '/d',
    name: 'Categories',
    component: Categories,
    exact: true
  },
  {
    path: '/d/:categoryUrl',
    name: 'CategoryDetails',
    component: CategoryDetails
  },
  {
    path: '/store',
    name: "Store",
    component: Store
  },
  {
    path: '/cart',
    name: "Cart",
    component: Cart
  },
  {
    path: '/checkout',
    name: "Checkout",
    component: Checkout
  }
]

const Router = () => {
  return (
    <Switch>
      <Route path='/' exact component={Main} />
      {routes.map((route, i) => {
        return (<Route path={route.path} exact={route.exact || false} component={route.component} key={i} />);
      })}
    </Switch>
  );
}

export default Router;