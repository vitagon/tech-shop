import React from 'react';
import Main from './components/main/Main';
import Categories from './components/categories/Categories';
import Store from './components/store/Store';
import { Route, Switch } from 'react-router-dom';

const Router = () => {
  return (
    <Switch>
      <Route path='/' exact component={Main} />
      <Route path='/admin/categories' component={Categories} />
      <Route path='/store' component={Store} />
    </Switch>
  );
}

export default Router;