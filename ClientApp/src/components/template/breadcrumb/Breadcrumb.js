import React from 'react';
import { Link } from 'react-router-dom';
import { matchPath, withRouter } from 'react-router-dom';

/*
 * I took snippets from here
 * https://stackoverflow.com/questions/42380448/how-do-i-create-react-router-v4-breadcrumbs
 * 
 */

export const appRoutes = [
  { path: '/admin/', breadcrumb: 'admin', header: 'Admin' },
  { path: '/admin/categories', breadcrumb: 'categories', header: 'Categories' },
  { path: '/store', breadcrumb: 'Store', header: 'Store' },
  { path: '/cart', breadcrumb: 'Cart', header: 'Shopping cart' },
  { path: '/checkout', breadcrumb: 'Checkout', header: 'Checkout' }
]

const Breadcrumb = ({ breadcrumbs, header, route }) => {
  return (
    <div id="breadcrumb" class="section">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <h3 class="breadcrumb-header">{header}</h3>
            <ul class="breadcrumb-tree">
              <li>
                <Link to="/">
                  Home
                </Link>
              </li>
              {breadcrumbs.map(({ breadcrumb, path, match }) => {
                if (path === route.path) {
                  return (
                    <li key={path} className="active">
                      {breadcrumb}
                    </li>
                  );
                } else {
                  return (
                    <li key={path}>
                      <Link to={match.url}>
                        {breadcrumb}
                      </Link>
                    </li>
                  );
                }
              })}
            </ul>
          </div>
        </div>
      </div>
    </div>
  );
}

const withBreadcrumbs = (routes) => {
  return (Component) => {
    return withRouter(props => {
      if (props.location.pathname === "/") {
        return null;
      }
      return (
        <Component
          {...props}
          breadcrumbs={
            getBreadcrumbs({
              pathname: props.location.pathname,
              routes,
            })
          }
          header={getHeader(props.location.pathname, routes)}
          route={getExactRouter(props.location.pathname, routes)}
        />
      )
    });
    //return (props) => { return (<Component {...props} />) };
  }
}

const getExactRouter = (pathname, routes) => {
  return routes.find(x => x.path === pathname);
}

const getHeader = (pathname, routes) => {
  let route = routes.find(x => x.path === pathname);
  return route ? route.header : null;
}

const renderer = ({ breadcrumb, match }) => {
  if (typeof breadcrumb === 'function') { return breadcrumb({ match }); }
  return breadcrumb;
};

export const getBreadcrumbs = ({ routes, pathname }) => {
  const matches = [];

  pathname
    .replace(/\/$/, '')
    .split('/')
    .reduce((previous, current) => {
      const pathSection = `${previous}/${current}`;

      let breadcrumbMatch;

      routes.some(({ breadcrumb, path }) => {
        const match = matchPath(pathSection, { exact: true, path });

        if (match) {
          breadcrumbMatch = {
            breadcrumb: renderer({ breadcrumb, match }),
            path,
            match,
          };
          return true;
        }

        return false;
      });

      if (breadcrumbMatch) {
        matches.push(breadcrumbMatch);
      }

      return pathSection;
    });

  return matches;
};

export default withBreadcrumbs(appRoutes)(Breadcrumb);