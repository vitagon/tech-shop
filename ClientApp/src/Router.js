import React from 'react';
import Main from './components/main/Main';
import Categories from './components/categories/Categories';
import Store from './components/store/Store';
import Cart from './components/cart/Cart';
import Checkout from './components/checkout/Checkout';
import { Route, Switch } from 'react-router-dom';

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
    component: Categories
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
        return (<Route path={route.path} exact={route.exact || false} component={route.component} />);
      })}
    </Switch>
  );
}

export default Router;