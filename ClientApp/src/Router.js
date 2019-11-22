import React from 'react';
import Main from './components/main/Main';
import Categories from './components/categories/Categories';
import { Route, Switch } from 'react-router-dom';

const Router = () => {
  return (
    <Switch>
      <Route path='/' exact component={Main} />
      <Route path='/admin/categories' component={Categories} />
    </Switch>
  );
}

export default Router;